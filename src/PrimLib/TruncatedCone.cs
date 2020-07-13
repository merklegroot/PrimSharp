using System;
using System.Collections.Generic;
using System.Text;

namespace PrimLib
{
    public class TruncatedCone : Prim
    {
        private const int DefaultResolution = 100;

        public TruncatedCone() : this(0.5m, 1, 1) { }

        public TruncatedCone(decimal r1, decimal r2, decimal h) { R1 = r1; R2 = r2; Height = h; }

        public decimal R1 { get; set; }

        public decimal R2 { get; set; }

        public decimal Height { get; set; }

        public int Resolution { get; set; } = DefaultResolution;

        public TruncatedCone Clone() => CloneAs<TruncatedCone>();

        public override string Render() => $"cylinder({{r1: {R1}, r2: {R2}, h: {Height}, center: true, fn: {Resolution}}})";
    }
}
