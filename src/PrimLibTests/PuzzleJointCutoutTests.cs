using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using PrimLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
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

            var result = puzzleJointCutout.Union(border).Render();
            _outputHelper.WriteLine(result);
        }
    }
}
