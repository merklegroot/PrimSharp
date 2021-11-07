using PrimDesign;
using Xunit;
using Xunit.Abstractions;
using PrimSharp;

namespace PrimDesignTests
{
    public class PuzzleJointCutoutTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleJointCutoutTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Puzzle_joint_cutout_with_defaults()
        {
            var puzzleJointCutout = new PuzzleJointCutout();
            var border = new Border(puzzleJointCutout.Size);

            var result = puzzleJointCutout.Union(border).ToOpenScad();
            _outputHelper.WriteLine(result);
        }
    }
}
