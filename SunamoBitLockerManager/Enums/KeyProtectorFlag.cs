namespace SunamoBitLockerManager.Enums;

    public enum KeyProtectorFlag : uint
    {
        /// <summary>
        ///     No effect.
        /// </summary>
        FLAG_NONE = 0x0000,

        /// <summary>
        ///     Specifies that the SID-based protector was protected to a service account.If this flag is specified, the caller
        ///     should ensure that it is running as the appropriate service account before calling UnlockWithAdSid (by temporarily
        ///     dropping impersonation, for example).
        /// </summary>
        FLAG_UNLOCK_AS_SERVICE_ACCOUNT = 0x0001
    }