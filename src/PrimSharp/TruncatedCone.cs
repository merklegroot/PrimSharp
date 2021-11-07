using System;
using System.Collections.Generic;
using System.Text;

namespace PrimSharp
{
    public record TruncatedCone : Prim
    {
        private const int DefaultResolution = 100;

        public TruncatedCone() : this(0.5m, 1, 1) { }

        public TruncatedCone(decimal r1, decimal r2, decimal h) { R1 = r1; R2 = r2; Height = h; }

        public decimal R1 { get; init; }

        public decimal R2 { get; init; }

        public decimal Height { get; init; }

        public int Resolution { get; init; } = DefaultResolution;

        public override string ToOpenScad() =>
            $"cylinder({{r1={R1}, r2={R2}, h={Height}, center=true, $fn={Resolution}}})";
    }
}
