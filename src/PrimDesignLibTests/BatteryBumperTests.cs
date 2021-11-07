﻿using PrimDesignLib;
using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
{
    public class BatteryBumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BatteryBumperTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Battery_container() => _outputHelper.WriteLine(new BatteryBumper().Render());

        [Fact]
        public void asdf() => _outputHelper.WriteLine(new Box(4, 4, 1).Subtract(new Box(2, 2, 1)).Render());
    }
}
