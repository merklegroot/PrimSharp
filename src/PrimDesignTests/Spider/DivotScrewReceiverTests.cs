using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class DivotScrewReceiverTests
{
    private readonly ITestOutputHelper _outputHelper;

    public DivotScrewReceiverTests(ITestOutputHelper outputHelper) => 
        _outputHelper = outputHelper;
    
    [Fact]
    public void Divot_screw_receiver_tests() =>
        _outputHelper.WriteLine(new DivotScrewReceiver().ToOpenScad());
}
