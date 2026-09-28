namespace SunamoBitLockerManager.Enums;

    public enum WipingStatus : uint
    {
        /// <summary>
        ///     The free space has not been wiped.
        /// </summary>
        FreeSpaceNotWiped = 0,

        /// <summary>
        ///     The free space has been wiped.
        /// </summary>
        FreeSpaceWiped = 1,

        /// <summary>
        ///     Free space wiping is currently in progress.
        /// </summary>
        FreeSpaceWipingInProgress = 2,

        /// <summary>
        ///     Free space wiping has been paused.
        /// </summary>
        FreeSpaceWipingPaused = 3
    }