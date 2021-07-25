using PrimLib;

namespace PrimDesignLib
{
    /// <summary>
    /// Cap to plug the air for the inflatable pool.
    /// The hole is 15mm.
    /// </summary>
    public class PoolCap : Prim
    {
        const decimal MainRadius = 15.0m;
        const decimal CapRadius = MainRadius + 2.5m;
        const decimal CapHeight = 2.0m;
        const decimal MainHeight = 4.0m;
        const decimal SlipHeight = 2.0m;
        const decimal SlipMinorRadius = 14.0m;
        const decimal CenterCutRadius = 12.0m;

        public override string Render()
        {
            var cap = new Cylinder(radius: CapRadius, height: CapHeight);
            var main = new Cylinder(radius: MainRadius, height: MainHeight);
            var slip = new TruncatedCone(r1: MainRadius, r2: SlipMinorRadius, h: SlipHeight);
            var centerCut = new Cylinder(radius: CenterCutRadius, height: MainHeight + SlipHeight);

            return cap
                .Union(main.TranslateZ(cap.Height / 2 + main.Height / 2))
                .Union(slip.TranslateZ(cap.Height / 2 + main.Height + slip.Height / 2))
                .Subtract(centerCut.TranslateZ(cap.Height / 2 + centerCut.Height / 2))
                .Render();
        }
    }
}
