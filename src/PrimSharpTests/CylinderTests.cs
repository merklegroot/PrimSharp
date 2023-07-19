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
    public void Cylinder_with_defaults() =>
        _outputHelper.WriteLine(new Cylinder().ToOpenScad());
    
    [Fact]
    public void Cylinder_with_multiple_radii() =>
        _outputHelper.WriteLine(new Cylinder
        {
            Height = 5,
            Radius = 2,
            Radius2 = 4
        }.ToOpenScad());
}