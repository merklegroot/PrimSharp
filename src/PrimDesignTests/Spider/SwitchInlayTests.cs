using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class SwitchInlayTests
{
    private readonly ITestOutputHelper _outputHelper;

    public SwitchInlayTests(ITestOutputHelper outputHelper) => 
        _outputHelper = outputHelper;

    [Fact]
    public void Switch_inlay() =>
        _outputHelper.WriteLine(
            new SwitchInlay().ToOpenScad());
}
