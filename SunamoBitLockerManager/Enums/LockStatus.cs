namespace SunamoBitLockerManager.Enums;

    public enum LockStatus : uint
    {
        /// <summary>
        ///     For a standard HDD:
        ///     The full contents of the volume are accessible. An unlocked volume is either fully decrypted or has the encryption
        ///     key available in
        ///     the clear on disk. The volume containing the current running operating system (for example, the running Windows
        ///     volume) is
        ///     always accessible and cannot be locked.
        ///     For an EHDD:
        ///     The band is perpetually unlocked.
        /// </summary>
        Unlocked = 0,

        /// <summary>
        ///     For a standard HDD:
        ///     All or a portion of the contents of the volume are not accessible. A locked volume must be partially or fully
        ///     encrypted and must not have
        ///     the encryption key available in the clear on disk.
        ///     For an EHDD:
        ///     The band is unlocked or locked.
        /// </summary>
        Locked = 1
    }