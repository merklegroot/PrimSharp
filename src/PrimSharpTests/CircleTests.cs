using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests;

public class CircleTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CircleTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;
    
    [Fact]
    public void Circle_with_defaults() =>
        _outputHelper.WriteLine(new Circle().ToOpenScad());
}