using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests;

public class Sector2dTests
{
    private readonly ITestOutputHelper _outputHelper;

    public Sector2dTests(ITestOutputHelper outputHelper)  =>
        _outputHelper = outputHelper;

    [Fact]
    public void Sector2d_with_defaults() =>
        _outputHelper.WriteLine(new Sector2d().ToOpenScad());

    [Fact]
    public void Sector_extrude() =>
        _outputHelper.WriteLine(new Sector2d().Extrude(2).ToOpenScad());
        
}
