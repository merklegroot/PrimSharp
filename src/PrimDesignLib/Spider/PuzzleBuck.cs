using PrimSharp;

namespace PrimDesignLib.Spider
{
    public record PuzzleBuck : Prim
    {
        public override string Render()
        {
            const decimal CutoutWidth = 67.3m;
            const decimal CutoutBreadth = 37.8m - 1.0m;
            const decimal WallThickness = 2.0m;
            const decimal FloorThickness = 1.25m;
            const decimal BumperBreadth = 48;

            const decimal HorizontalCutoutBreadth = 20;
            const decimal HorizontalCutoutHeight = 12.5m;

            const decimal ComponentLowerHeight = 6.7m;
            const decimal ComponentUpperHeight = ComponentLowerHeight + HorizontalCutoutHeight;

            var bumper = new Bumper(BumperBreadth);

            var box = new Box(
                CutoutWidth + 2.0m * WallThickness,
                CutoutBreadth + 2.0m * WallThickness,
                ComponentUpperHeight,
                WallThickness,
                FloorThickness);            

            var horizontalCutout = new Cube(box.Width, HorizontalCutoutBreadth, HorizontalCutoutHeight);

            var boxWithHorizontalCutout = box
                .Subtract(horizontalCutout.TranslateZ(box.Height / 2 - horizontalCutout.Height / 2));

            var cubeCutout = new Cube(
                box.Width,
                box.Breadth,
                box.Height);

            return bumper.TranslateZ(bumper.Height / 2)
                .Subtract(cubeCutout.TranslateZ(cubeCutout.Height / 2))
                .Union(boxWithHorizontalCutout.TranslateZ(box.Height / 2))
                .Render();
        }
    }
}
