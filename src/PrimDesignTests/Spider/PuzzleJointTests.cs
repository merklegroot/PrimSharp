using PrimDesign;
using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider
{
    public class PuzzleJointTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleJointTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Puzzle_joint_with_defaults()
        {
            var joint = new PuzzleJoint();
            var border = new Border(joint.Size);

            var result = joint.Union(border).ToOpenScad();
            _outputHelper.WriteLine(result);
        }
    }
}
