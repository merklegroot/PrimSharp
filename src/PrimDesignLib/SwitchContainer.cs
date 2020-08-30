using PrimLib;

namespace PrimDesignLib
{
    public class SwitchContainer : Prim, ISizedPrim
    {
        private const decimal WallThickness = 2.5m;
        private const decimal FloorThickness = 4.0m;

        private decimal CutoutWidth = 13.5m;
        private decimal CutoutBreadth = 9.7m;
        private decimal CutoutHeight = 23.5m;

        public decimal Width => CutoutWidth + 2 * WallThickness;
        public decimal Breadth => CutoutBreadth + 2 * WallThickness;
        public decimal Height => CutoutHeight + FloorThickness;

        public decimal[] Size => new decimal[] { Width, Breadth, Height };

        public override string Render()
        {
            var box = new Box(Width, Breadth, Height, WallThickness, FloorThickness);
            var sideCuotut = new Cube(Width - 4 * WallThickness, Breadth, Height - FloorThickness);

            return box.Subtract(sideCuotut.TranslateZ(FloorThickness/2)).Render();
        }
    }
}
