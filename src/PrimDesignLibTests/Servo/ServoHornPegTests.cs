using PrimDesignLib.Servo;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests.Servo
{
    public class ServoHornPegTests
    {
        private readonly ITestOutputHelper _outputHelper;
        public ServoHornPegTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Servo_horn_peg() => _outputHelper.WriteLine(new ServoHornPeg().Render());
    }
}
