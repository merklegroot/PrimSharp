using PrimDesignLib.Servo;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests.Servo
{
    public class ServoHornTests
    {
        private readonly ITestOutputHelper _outputHelper;
        public ServoHornTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Servo_arm() => _outputHelper.WriteLine(new ServoHorn().Render());
    }
}
