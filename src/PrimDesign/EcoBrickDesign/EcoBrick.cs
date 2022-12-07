using PrimDesign.BottleDesign;
using PrimSharp;

namespace PrimDesign.EcoBrickDesign
{
    public record EcoBrick : Prim
    {
        private static decimal BottleHeight => 8.0m.Inch();

        private static decimal BrickWidth => 3.0m.Inch();


        private static decimal BottomGap = 0.5m.Inch();


        private static decimal TopGap = 0.5m.Inch();

        private static decimal BrickHeight =>
            BottleHeight + BottomGap + TopGap;

        private static ISizedPrim Brick => new Box()
        {
            Width = BrickHeight,
            Breadth = BrickWidth,
            Height = BrickWidth,
            WallThickness = 4,
            FloorThickness = 4
        };

        public override string ToOpenScad()
        {
            var bottle = new Bottle();

            return Brick.RotateY(90)
                .Union(
                    new Bottle().TranslateZ(bottle.Height / 2 - BrickHeight / 2 + BottomGap)
                )
                .RotateY(-90)
                .ToOpenScad();
        }
    }
}
