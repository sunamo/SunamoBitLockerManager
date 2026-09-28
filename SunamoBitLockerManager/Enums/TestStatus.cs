namespace SunamoBitLockerManager.Enums;

    public enum TestStatus
    {
        /// <summary>
        ///     If a test was requested, the test has succeeded on the last computer restart and volume encryption is now in
        ///     progress. For the encryption status,
        ///     see the GetConversionStatus method. Otherwise, no test ran on the last computer restart and none is pending.
        /// </summary>
        NotFailed_and_NonePending = 0,

        /// <summary>
        ///     Volume encryption did not start. All key protectors were removed.
        ///     To resolve a failed test:
        ///     Consult the information in the TestError parameter.
        ///     Add key protectors and use the EncryptAfterHardwareTest method again.
        /// </summary>
        Failed = 1,

        /// <summary>
        ///     A test has been requested and will run on the next computer restart.
        /// </summary>
        Pending = 2
    }