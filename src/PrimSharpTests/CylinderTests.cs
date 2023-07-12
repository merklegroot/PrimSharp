using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests;

public class CylinderTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CylinderTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Cylinder_with_defaults()
    {
        var result = new Cylinder().ToOpenScad();
        _outputHelper.WriteLine(result);
    }
}