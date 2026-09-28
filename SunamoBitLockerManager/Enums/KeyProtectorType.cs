namespace SunamoBitLockerManager.Enums;

    public enum KeyProtectorType : uint
    {
        /// <summary>
        ///     Unknown or other protector type.
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     Trusted Platform Module (TPM).
        /// </summary>
        TPM = 1,

        /// <summary>
        ///     External key.
        /// </summary>
        ExternalKey = 2,

        /// <summary>
        ///     Numerical password.
        /// </summary>
        NumericalPassword = 3,

        /// <summary>
        ///     TPM And PIN.
        /// </summary>
        TPMAndPIN = 4,

        /// <summary>
        ///     TPM And Startup Key.
        /// </summary>
        TPMAndStartupKey = 5,

        /// <summary>
        ///     TPM And PIN And Startup Key.
        /// </summary>
        TPMAndPINAndStartupKey = 6,

        /// <summary>
        ///     Public Key.
        /// </summary>
        PublicKey = 7,

        /// <summary>
        ///     Passphrase.
        /// </summary>
        Passphrase = 8,

        /// <summary>
        ///     TPM Certificate.
        /// </summary>
        TPMCertificate = 9,

        /// <summary>
        ///     CryptoAPI Next Generation (CNG) Protector.
        /// </summary>
        CNG = 10
    }