namespace SunamoBitLockerManager.Enums;

    public enum EncryptionMethod : uint
    {
        /// <summary>
        ///     The volume is not encrypted.
        /// </summary>
        None = 0,

        /// <summary>
        ///     The volume has been fully or partially encrypted with the Advanced Encryption Standard (AES) algorithm enhanced
        ///     with a diffuser layer, using an AES key size of 128 bits.
        ///     This method is no longer available on devices running Windows 8.1 or higher.
        /// </summary>
        AES_128_WITH_DIFFUSER = 1,

        /// <summary>
        ///     The volume has been fully or partially encrypted with the Advanced Encryption Standard (AES) algorithm enhanced
        ///     with a diffuser layer, using an AES key
        ///     size of 256 bits.This method is no longer available on devices running Windows 8.1 or higher.
        /// </summary>
        AES_256_WITH_DIFFUSER = 2,

        /// <summary>
        ///     The volume has been fully or partially encrypted with the Advanced Encryption Standard (AES) algorithm, using an
        ///     AES key size of 128 bits.
        /// </summary>
        AES_128 = 3,

        /// <summary>
        ///     The volume has been fully or partially encrypted with the Advanced Encryption Standard(AES) algorithm, using an AES
        ///     key size of 256 bits.
        /// </summary>
        AES_256 = 4,

        /// <summary>
        ///     The volume has been fully or partially encrypted by using the hardware capabilities of the drive.
        /// </summary>
        HARDWARE_ENCRYPTION = 5,

        /// <summary>
        ///     The volume has been fully or partially encrypted with XTS using the Advanced Encryption Standard(AES), and an AES
        ///     key size of 128 bits.
        ///     This method is only available on devices running Windows 10, version 1511 or higher.
        /// </summary>
        XTS_AES_128 = 6,

        /// <summary>
        ///     The volume has been fully or partially encrypted with XTS using the Advanced Encryption Standard(AES), and an AES
        ///     key size of 256 bits.
        ///     This method is only available on devices running Windows 10, version 1511 or higher.
        /// </summary>
        XTS_AES_256 = 7,

        /// <summary>
        ///     The volume has been fully or partially encrypted with an unknown algorithm and key size.
        /// </summary>
        UNKNOWN = uint.MaxValue - 1
    }