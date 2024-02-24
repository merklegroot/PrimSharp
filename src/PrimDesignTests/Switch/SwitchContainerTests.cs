using PrimDesign.Switch;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Switch;

public class SwitchContainerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public SwitchContainerTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;
    
    [Fact]
    public void Switch_container() =>
        _outputHelper.WriteLine(
            new SwitchContainer().ToOpenScad());
}
