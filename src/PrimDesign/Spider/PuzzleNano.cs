using PrimSharp;

namespace PrimDesign.Spider
{
    public record PuzzleNano : Prim
    {
        public override string ToOpenScad()
        {
            const decimal CutoutWidth = 55.0m;
            const decimal CutoutBreadth = 43.5m;
            const decimal WallThickness = 2.0m;
            const decimal FloorThickness = 1.5m;
            const decimal BumperBreadth = 50;

            var bumper = new PuzzleBumper { Breadth = BumperBreadth };

            var box = new Box(
                CutoutWidth + 2.0m * WallThickness,
                CutoutBreadth + 2.0m * WallThickness,
                5,
                WallThickness,
                FloorThickness);

            var cubeCutout = new Cube(
                CutoutWidth + 2.0m * WallThickness,
                CutoutBreadth + 2.0m * WallThickness,
                5);

            return bumper.TranslateZ(bumper.Height / 2)
                .Subtract(cubeCutout.TranslateZ(cubeCutout.Height / 2))
                .Union(box.TranslateZ(box.Height / 2))
                .ToOpenScad();
        }
    }
}
