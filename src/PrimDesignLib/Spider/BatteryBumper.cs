using PrimLib;
using System;

namespace PrimDesignLib
{
    public class BatteryBumper : Prim, ISizedPrim
    {
        private static class BatteryDim
        {
            public static decimal Width => 75.3m;
            public static decimal Breadth = 36.8m;
            public static decimal Height = 20.0m;         
        }

        private const decimal Thickness = 2.25m;


        public decimal Height => BatteryDim.Height + Thickness;
        public decimal Width => BatteryDim.Width + 2 * Thickness;

        public decimal Breadth => BatteryDim.Breadth + 2 * Thickness;

        public override string Render()
        {
            var outerBox = new Box(Width, Breadth, Height, Thickness, Thickness);

            var sideCutoutA = new Cube(Thickness, 14, Height - Thickness);

            var sideCutoutB = new Cube(Thickness, 10.0m, Height - Thickness);

            return outerBox
                .Subtract(sideCutoutA.Translate(outerBox.Width / 2 - sideCutoutA.Width / 2, 0, outerBox.Height / 2 - sideCutoutA.Height / 2))
                .Subtract(sideCutoutB.Translate(-outerBox.Width / 2 + sideCutoutB.Width / 2, outerBox.Breadth / 2 - sideCutoutB.Breadth / 2 - Thickness, outerBox.Height / 2 - sideCutoutB.Height / 2))
                .Subtract(sideCutoutB.Translate(-outerBox.Width / 2 + sideCutoutB.Width / 2, -(outerBox.Breadth / 2 - sideCutoutB.Breadth / 2 - Thickness), outerBox.Height / 2 - sideCutoutB.Height / 2))
                .Render();
        }
    }
}
