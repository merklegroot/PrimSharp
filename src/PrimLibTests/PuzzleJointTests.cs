using PrimLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
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

            var result = joint.Union(border).Render();
            _outputHelper.WriteLine(result);
        }
    }
}
