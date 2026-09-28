namespace SunamoBitLockerManager.Enums;

    public enum FVEMetadataVersion : uint
    {
        /// <summary>
        ///     The operating system is unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     Windows Vista format, meaning that the volume was protected with BitLocker on a computer running Windows Vista.
        /// </summary>
        Vista = 1,

        /// <summary>
        ///     Windows 7 format, meaning that the volume was protected with BitLocker on a computer running Windows 7 or the
        ///     metadata format was upgraded by using the UpgradeVolume method.
        /// </summary>
        Win7 = 2
    }