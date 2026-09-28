namespace SunamoBitLockerManager.Enums;

    public enum ActiveDirectoryFlag : uint
    {
        /// <summary>
        ///     No effect.
        /// </summary>
        None = 0x0000,

        /// <summary>
        ///     Specifies that the SID-based protector was protected to a service account.If this flag is specified, the caller
        ///     should ensure that it is running
        ///     as the appropriate service account before calling UnlockWithAdSid (by temporarily dropping impersonation, for
        ///     example).
        /// </summary>
        UnlockAsServiceAccount = 0x0001
    }