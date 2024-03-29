using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests;

public class BoxTests
{
    private readonly ITestOutputHelper _outputHelper;
    public BoxTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Box_with_defaults() =>
        _outputHelper.WriteLine(new Box().ToOpenScad());

    [Fact]
    public void Box_with_enough_space_for_cutout() =>
        _outputHelper.WriteLine(new Box(4, 4, 4).ToOpenScad());        
}
