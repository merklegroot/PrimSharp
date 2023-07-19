﻿using PrimSharp.Puzzle;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests.Puzzle;

public class PuzzleJointTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PuzzleJointTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Puzzle_joint() =>
        _outputHelper.WriteLine(new PuzzleJoint().ToOpenScad());        
}