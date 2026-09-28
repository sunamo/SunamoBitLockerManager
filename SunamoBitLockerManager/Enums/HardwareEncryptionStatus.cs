namespace SunamoBitLockerManager.Enums;

    public enum HardwareEncryptionStatus : uint
    {
        /// <summary>
        ///     Hardware encryption is not supported.
        /// </summary>
        Notsupported = 0,

        /// <summary>
        ///     Drive encryption is not supported.
        /// </summary>
        NoProtection = 1,

        /// <summary>
        ///     The encryption method is software-based.
        /// </summary>
        UsesSoftware = 2,

        /// <summary>
        ///     The drive supports hardware encryption.
        /// </summary>
        UsesHardware = 3
    }