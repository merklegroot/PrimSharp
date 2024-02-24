using PrimDesign.EcoBrickDesign;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.EcoBrickDesign;

public class EcoBrickTests
{
    private readonly ITestOutputHelper _outputHelper;

    public EcoBrickTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Ecobrick_test() =>
        _outputHelper.WriteLine(new EcoBrick().ToOpenScad());    
}
