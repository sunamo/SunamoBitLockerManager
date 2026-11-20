namespace SunamoBitLockerManager;

using BitLockerManager2 = SunamoBitLockerManager.BitLockerManager;

/// <summary>
/// Helper for determining whether a specific drive is locked by BitLocker (makes sense only here,
/// not in PlatformIndependentNuGetPackages in general, because it requires the Windows-only System.Management).
/// </summary>
public class BitLockerHelper
{
    private static DriveInfo[] _drives;

    private static readonly List<Tuple<char, BitLockerManager2>> drives = new List<Tuple<char, BitLockerManager2>>();

    /// <summary>
    /// Loads all drives and their BitLocker status, returns a function for querying a specific drive by letter.
    /// </summary>
    public static Func<char, bool> Init()
    {
        _drives = BitLockerManager2.EnumDrives();

        foreach (DriveInfo drive in _drives)
        {
            try
            {
                if (BitLockerManager2.GetProtectionStatus(drive) == ProtectionStatus.Protected)
                {
                    drives.Add(new Tuple<char, BitLockerManager2>(drive.Name[0], new BitLockerManager2(drive)));
                }

                if (BitLockerManager2.GetProtectionStatus(drive) == ProtectionStatus.Unknown &&
                    BitLockerManager2.IsLocked(drive))
                {
                    drives.Add(new Tuple<char, BitLockerManager2>(drive.Name[0], new BitLockerManager2(drive)));
                }
            }
            catch (Exception exception)
            {
                if (exception.Message != "Access denied ")
                {
                    throw;
                }
            }
        }

        return IsFolderLockedByBitLocker;
    }

    /// <summary>
    /// Returns true if the drive with the given letter is locked by BitLocker.
    /// </summary>
    public static bool IsFolderLockedByBitLocker(char driveLetter)
    {
        foreach (Tuple<char, BitLockerManager2> item in drives)
        {
            if (item.Item1 == char.ToUpper(driveLetter))
            {
                return item.Item2.IsLocked();
            }
        }

        return false;
    }
}