// variables names: ok
namespace SunamoBitLockerManager.Tests;

public class BitLockerManagerTests
{
    [Fact]
    public void IsSupportedOS_ReturnsTrueOnWindowsVistaOrHigher()
    {
        var isSupported = BitLockerManager.IsSupportedOS();
        Assert.True(isSupported);
    }

    [Fact]
    public void EnumDrives_ReturnsAtLeastOneDrive()
    {
        var drives = BitLockerManager.EnumDrives();
        Assert.NotEmpty(drives);
    }
}
