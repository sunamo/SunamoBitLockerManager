namespace SunamoBitLockerManager.Enums;

    public enum ForceEncryptionType : uint
    {
        /// <summary>
        ///     The encryption type is not specified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        ///     Software encryption.
        /// </summary>
        Software = 1,

        /// <summary>
        ///     Hardware encryption.
        /// </summary>
        Hardware = 2
    }