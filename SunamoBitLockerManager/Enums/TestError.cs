namespace SunamoBitLockerManager.Enums;

    public enum TestError : uint
    {
        /// <summary>
        ///     No errors occurred or no hardware test ran on the last computer restart.
        /// </summary>
        NoError = 0,

        /// <summary>
        ///     A USB flash drive with an external key file was not found. If this failure persists, the computer cannot read USB
        ///     drives during restart.
        ///     You may not be able to use external keys to unlock the operating system volume during restart.
        /// </summary>
        KEYFILE_NOT_FOUND = 0x8031003C,

        /// <summary>
        ///     The external key file on the USB flash drive was corrupt. Try a different USB flash drive to store the external key
        ///     file.
        /// </summary>
        KEYFILE_INVALID = 0x8031003D,

        /// <summary>
        ///     The TPM is either disabled or deactivated or both disabled and deactivated. To turn on the TPM, use the Win32_Tpm
        ///     WMI
        ///     provider or run the TPM management snap-in (Tpm.msc).
        /// </summary>
        TPM_DISABLED = 0x8031003F,

        /// <summary>
        ///     The TPM detected a change in operating system restart services within the current platform validation profile.
        ///     Remove any startup CD
        ///     or DVD from the computer. If this failure persists, check that the latest firmware and BIOS upgrades are installed,
        ///     and that the TPM is otherwise working properly.
        /// </summary>
        TPM_INVALID_PCR = 0x80310041,

        /// <summary>
        ///     The provided PIN was incorrect.
        /// </summary>
        PIN_INVALID = 0x80310043
    }