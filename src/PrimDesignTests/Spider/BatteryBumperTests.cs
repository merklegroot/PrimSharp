using PrimDesign.Spider;
using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class BatteryBumperTests
{
    private readonly ITestOutputHelper _outputHelper;

    public BatteryBumperTests(ITestOutputHelper outputHelper) => 
        _outputHelper = outputHelper;

    [Fact]
    public void Battery_container() => 
        _outputHelper.WriteLine(new BatteryBumper().ToOpenScad());
}
