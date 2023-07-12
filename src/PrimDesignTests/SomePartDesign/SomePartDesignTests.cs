using PrimDesign.SomePartDesign;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.SomePartDesign;

public class SomePartDesignTests
{
    private readonly ITestOutputHelper _outputHelper;

    public SomePartDesignTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;
        
    [Fact]
    public void Some_part() =>
        _outputHelper.WriteLine(
            new SomePart().ToOpenScad());
}