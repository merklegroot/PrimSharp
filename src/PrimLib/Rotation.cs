using System.Text;

namespace PrimLib
{
    public class Rotation : Prim, IRotation
    {
        private readonly IPrim _prim;

        public Rotation(IPrim prim, int axis, decimal angle)
        {
            _prim = prim;
            Axis = axis;
            Angle = angle;
        }

        public int Axis { get; private set; }

        public decimal Angle { get; private set; }

        public override string Render() => new StringBuilder()
            .AppendLine(_prim.Render())
            .AppendLine($".rotate{AxisName}({Angle})")
            .ToString();

        private string AxisName => new string[] { "X", "Y", "Z" }[Axis];
    }
}
