using PrimSharp;
using PrimSharp.Extensions;

namespace PrimDesign.Spider
{
    public record PuzzlePca : Prim
    {
        public override string ToOpenScad()
        {
            /*
                const pcaDim = {
                    width: 62,
                    breadth: 25.8, // 25.5,
                    height: 20
                };

                pcaDim.thickness = 2.25;
                pcaDim.bumperHeight = pcaDim.height + pcaDim.thickness;
                pcaDim.bumperWidth = pcaDim.width + 2 * pcaDim.thickness;
                pcaDim.bumperBreadth = pcaDim.breadth + 2 * pcaDim.thickness;
            */

            const decimal PcaCutoutWidth = 62.4m;
            const decimal PcaCutoutBreadth = 25.8m;
            const decimal WallThickness = 2.0m;
            const decimal FloorThickness = 1.5m;
            const decimal BumperBreadth = 40;


            var bumper = new PuzzleBumper { Breadth = BumperBreadth };

            var pcaBorder = new Box(
                PcaCutoutWidth + 2.0m * WallThickness,
                PcaCutoutBreadth + 2.0m * WallThickness,
                5,
                WallThickness,
                FloorThickness);

            return bumper.Stack(pcaBorder).ToOpenScad();
        }
    }
}
