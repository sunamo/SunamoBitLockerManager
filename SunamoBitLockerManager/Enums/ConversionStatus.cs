namespace SunamoBitLockerManager.Enums;

    public enum ConversionStatus : uint
    {
        /// <summary>
        ///     For a standard hard drive (HDD), the volume is fully decrypted.
        ///     For a hardware encrypted hard drive (EHDD), the volume is perpetually unlocked.
        /// </summary>
        FullyDecrypted = 0,

        /// <summary>
        ///     For a standard hard drive (HDD), the volume is fully encrypted.
        ///     For a hardware encrypted hard drive (EHDD), the volume is not perpetually unlocked.
        /// </summary>
        FullyEncrypted = 1,

        /// <summary>
        ///     The volume is partially encrypted.
        /// </summary>
        EncryptionInProgress = 2,

        /// <summary>
        ///     The volume is partially encrypted.
        /// </summary>
        DecryptionInProgress = 3,

        /// <summary>
        ///     The volume has been paused during the encryption progress. The volume is partially encrypted.
        /// </summary>
        EncryptionPaused = 4,

        /// <summary>
        ///     The volume has been paused during the decryption progress. The volume is partially encrypted.
        /// </summary>
        DecryptionPaused = 5
    }