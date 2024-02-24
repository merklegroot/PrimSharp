using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class PowerSectionTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PowerSectionTests(ITestOutputHelper outputHelper) => 
        _outputHelper = outputHelper;

    [Fact]
    public void Power_section() => 
        _outputHelper.WriteLine(new PowerSection().ToOpenScad());
}
