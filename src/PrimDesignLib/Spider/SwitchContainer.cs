using PrimLib;

namespace PrimDesignLib
{
    /// <summary>
    /// Fits a small on/off switch.
    /// </summary>
    public class SwitchContainer : Prim, ISizedPrim
    {
        private Cube TopperCutout = new Cube(13.5m, 9.7m, 2.0m);

        private const decimal TopperSpace = 3.5m;

        private Box Topper => new Box(TopperCutout.Width + 2 * TopperSpace, TopperCutout.Breadth + 2 * TopperSpace, TopperCutout.Height, TopperSpace, 0);

        private Arch WireCutoutA => new Arch(width: 5.0m, breadth: Topper.Breadth, height: 7.5m);
        private Arch WireCutoutB => new Arch(width: 5.0m, breadth: Topper.Width, height: 7.5m);

        private const decimal WallThickness = 2.0m;
        public decimal Width => Topper.Width;
        public decimal Breadth => Topper.Breadth;
        public decimal Height => 19.0m;

        public override string Render() =>
            new Box(Topper.Width, Topper.Breadth, Height, WallThickness, 0)                
                .Union(Topper.TranslateZ(Height / 2 - Topper.Height / 2))
                .Subtract(WireCutoutA.TranslateZ(-Height / 2 + WireCutoutA.Height / 2))
                .Subtract(WireCutoutB.RotateZ(90).TranslateZ(-Height / 2 + WireCutoutB.Height / 2))
                .Render();
    }
}
