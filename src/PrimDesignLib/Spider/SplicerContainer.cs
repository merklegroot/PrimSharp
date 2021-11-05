using PrimLib;

namespace PrimDesignLib.Spider
{
    public record SplicerContainer : Prim, ISizedPrim
    {
        private const decimal LowerHeight = 2.4m;
        private const decimal UpperHeight = 8.0m;

        private const decimal FloorThickness = 1.0m;
        private const decimal WallThickness = 1.0m;

        public decimal Width => 20 + 2 * WallThickness;

        public decimal Breadth => 17.40m + 2 * WallThickness;

        public decimal Height => UpperHeight + FloorThickness;

        private const decimal HorizontalStabilizerBreadth = 2.5m;
        private const decimal HorizontalStabilizerHeight = LowerHeight;
        private const decimal HorizontalStabilizerGapSize = 5.4m;

        private const decimal TapRadius = 1.0m;
        private const decimal TapHeight = 10.0m;

        public override string Render()
        {
            var box = new Box(Width, Breadth, Height, WallThickness, FloorThickness);
            var horizontalCutout = new Cube(box.Width, box.Breadth - 2 * 1.43m, box.Height - FloorThickness - LowerHeight);

            var horizontalStabilizer = new Cube(box.Width - 2 * WallThickness, HorizontalStabilizerBreadth, HorizontalStabilizerHeight);
            var stabilizerGap = new Cube(HorizontalStabilizerGapSize, horizontalStabilizer.Breadth, horizontalCutout.Height);

            var tap = new Cylinder(TapRadius, TapHeight);

            return box
                .Subtract(horizontalCutout.TranslateZ(box.Height / 2-horizontalCutout.Height / 2 + FloorThickness))
                .Subtract(tap)
                .Union((horizontalStabilizer.Subtract(stabilizerGap)).TranslateZ(
                    -(box.Height / 2)
                    + FloorThickness
                    + horizontalStabilizer.Height / 2
                ))
                .Render();
        }
    }
}
