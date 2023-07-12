using PrimDesign.BottleDesign;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.BottleDesign;

public class BottleTests
{
    private readonly ITestOutputHelper _outputHelper;

    public BottleTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Bottle_test() =>
        _outputHelper.WriteLine(new Bottle().ToOpenScad());
}