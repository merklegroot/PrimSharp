﻿using PrimSharp;
using PrimSharp.Puzzle;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests.Puzzle;

public class PuzzleJointCutoutTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PuzzleJointCutoutTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Puzzle_joint_cutout()
    {
        var puzzleJointCutout = new PuzzleJointCutout();
        var border = new Border(puzzleJointCutout.Size);

        var result = puzzleJointCutout.Union(border).ToOpenScad();
        _outputHelper.WriteLine(result);
    }
}
