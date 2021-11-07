using System.Collections.Generic;
using System.Text;

namespace PrimSharp
{
    public record Rotation : Prim, IRotation
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

        private string AxisName => new string[] { "X", "Y", "Z" }[Axis];

        public override string ToOpenScad()
        {
            var commaSeparated =
                string.Join(", ",
                    new List<decimal>
                    {
                        Axis == 0 ? Angle : 0,
                        Axis == 1 ? Angle : 0,
                        Axis == 2 ? Angle : 0
                    });

            return new StringBuilder()
                .AppendLine($"rotate([{commaSeparated}])")
                .AppendLine(_prim.ToOpenScad())
                .ToString();
        }
    }
}
