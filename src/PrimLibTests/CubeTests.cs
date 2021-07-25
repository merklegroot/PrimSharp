﻿using PrimLib;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
{
    public class CubeTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public CubeTests(ITestOutputHelper outputHelper) { _outputHelper = outputHelper; }

        [Fact]
        public void Cube_with_defaults()
        {
            _outputHelper.WriteLine(new Cube().Render());
        }

        [Fact]
        public void Rotated_cube()
        {
            var rotation = new Cube().RotateZ(45);

            rotation.Angle.ShouldBe(45);
            rotation.Axis.ShouldBe(2);

            var result = rotation.Render();
            _outputHelper.WriteLine(result);
        }

        [Fact]
        public void Cube_subtraction_test()
        {
            var a = new Cube();
            var b = new Cube();

            _outputHelper.WriteLine(a.Subtract(b).Render());
        }
    }
}
