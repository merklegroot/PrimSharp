using PrimDesign.Connectors;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Connectors;

public class WagoContainerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public WagoContainerTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Wago_container() =>
        _outputHelper.WriteLine(new WagoContainer().ToOpenScad());
}