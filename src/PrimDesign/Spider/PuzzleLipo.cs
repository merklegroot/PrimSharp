using PrimSharp;

namespace PrimDesign.Spider
{
    public record PuzzleLipo : Prim
    {
        public override string ToOpenScad()
        {
            /*
const batteryDim = {
    width: 75.5,
    breadth: 37.0,
    height: 20
};

            */


            const decimal CutoutWidth = 75.5m;
            const decimal CutoutBreadth = 37.0m;
            const decimal WallThickness = 2.0m;
            const decimal FloorThickness = 1.25m;
            const decimal BumperBreadth = 48;
            const decimal ComponentUpperHeight = 20;

            var bumper = new PuzzleBumper(BumperBreadth);

            var box = new Box(
                CutoutWidth + 2.0m * WallThickness,
                CutoutBreadth + 2.0m * WallThickness,
                ComponentUpperHeight,
                WallThickness,
                FloorThickness);

            var horizontalCutout = new Cube(box.Width, box.Breadth - 2*WallThickness, box.Height - FloorThickness);

            var horizontalAddition = new Cube(box.Width, 10, box.Height - FloorThickness);

            var horizontalAdditionMod = horizontalAddition.Subtract(new Cube(box.Width - 2*WallThickness, 10, box.Height - FloorThickness));

            var boxWithHorizontalCutout = box
                .Subtract(horizontalCutout.TranslateZ(box.Height / 2 - horizontalCutout.Height / 2))
                .Union(horizontalAdditionMod.TranslateZ(box.Height / 2 - horizontalAddition.Height / 2));

            var cubeCutout = new Cube(
                box.Width,
                box.Breadth,
                box.Height);

            return bumper.TranslateZ(bumper.Height / 2)
                .Subtract(cubeCutout.TranslateZ(cubeCutout.Height / 2))
                .Union(boxWithHorizontalCutout.TranslateZ(box.Height / 2))
                .ToOpenScad();
        }
    }
}
