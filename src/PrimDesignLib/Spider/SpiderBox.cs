using PrimSharp;

namespace PrimDesignLib.Spider
{
    /// <summary>
    /// A simple box to fit stuff inside the spider.
    /// This is a temporary solution.
    /// </summary>
    public record SpiderBox : Prim, ISizedPrim
    {
        private const decimal WallThickness = 1.5m;
        private const decimal FloorThickness = 1.5m;

        public decimal Width => 148 + 3m;
        public decimal Breadth => 85 + 0.5m;
        public decimal Height => 20;

        const decimal WingSize = 48.0m;
        const decimal WingHangover = 2.5m;
        private const decimal ScrewnHoleRadius = 1;

        public decimal[] Size => new decimal[] { Width, Breadth, Height };

        private Cylinder ScrewHole => new Cylinder { Radius = ScrewnHoleRadius, Height = FloorThickness };

        private Cube Wing => new Cube(WingSize, Breadth + 2 * WingHangover, FloorThickness);

        public override string Render()
        {
            var box = new Box(Width, Breadth, Height, 
                // WallThickness, 
                0,
                FloorThickness);

            const decimal cutoutGrace = 4.5m; //  7.5m;

            var floorCutout = new Cube(Width - 2*cutoutGrace, Breadth - 2 * cutoutGrace, FloorThickness);

            var result = box
                .Union(Wing.TranslateZ(floorCutout.Height / 2 - box.Height / 2))
                .Subtract(floorCutout.TranslateZ(floorCutout.Height / 2 - box.Height / 2));

            for (var i = 0; i < 4; i++)
            {
                var offsetX = (i % 2 == 0 ? 1 : -1) * (Width / 2 - cutoutGrace / 2 - WallThickness / 2);
                var offsetY = (i /2 >= 1 ? 1 : -1) * (Breadth / 2 - cutoutGrace / 2 - WallThickness / 2);
                result = result.Subtract(ScrewHole.Translate(offsetX, offsetY, floorCutout.Height / 2 - box.Height / 2));
            }

            return result.Render();
        }
    }
}
