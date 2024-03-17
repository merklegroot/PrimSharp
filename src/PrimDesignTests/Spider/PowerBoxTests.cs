using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class PowerBoxTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PowerBoxTests(ITestOutputHelper outputHelper) => 
        _outputHelper = outputHelper;

    [Fact]
    public void PowerBox() => 
        _outputHelper.WriteLine(new PowerBox{ WallThickness = 1.5m}.ToOpenScad());
}