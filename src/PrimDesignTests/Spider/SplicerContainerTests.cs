using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class SplicerContainerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public SplicerContainerTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void Splicer_container() => _outputHelper.WriteLine(new SplicerContainer().ToOpenScad());
}