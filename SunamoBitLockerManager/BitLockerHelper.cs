using BitLockerManager2 = SunamoBitLockerManager.BitLockerManager;

namespace SunamoBitLockerManager;

/// <summary>
/// Helper pro zjištění, jestli je konkrétní disk uzamčený BitLockerem (dává smysl jen tady,
/// ne v PlatformIndependentNuGetPackages obecně, protože to vyžaduje Windows-only System.Management).
/// </summary>
public class BitLockerHelper
{
    private static DriveInfo[] _drives;

    private static readonly List<Tuple<char, BitLockerManager2>> drives = new List<Tuple<char, BitLockerManager2>>();

    /// <summary>
    /// Načte všechny disky a jejich stav BitLockeru, vrátí funkci pro dotaz na konkrétní disk podle písmene.
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
            catch (Exception ex)
            {
                if (ex.Message != "Access denied ")
                {
                    throw;
                }
            }
        }

        return IsFolderLockedByBitLocker;
    }

    /// <summary>
    /// Vrátí true, pokud je disk s daným písmenem uzamčený BitLockerem.
    /// </summary>
    public static bool IsFolderLockedByBitLocker(char ch)
    {
        foreach (Tuple<char, BitLockerManager2> item in drives)
        {
            if (item.Item1 == char.ToUpper(ch))
            {
                return item.Item2.IsLocked();
            }
        }

        return false;
    }
}
