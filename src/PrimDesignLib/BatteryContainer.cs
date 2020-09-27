using PrimLib;

namespace PrimDesignLib
{
    public class BatteryContainer : Prim, ISizedPrim
    {
        private Cube Battery => new Cube(width: 75.3m, breadth: 36.8m, height: 20.0m);

        private const decimal CutoutTol = 1.5m;

        private Cube BatteryCutout => new Cube(Battery.Width + 2 * CutoutTol, Battery.Breadth + 2 * CutoutTol, Battery.Height + CutoutTol);

        private const decimal WallThickness = 1.5m;

        private const decimal FloorThickness = 1.0m;

        public decimal Width => BatteryCutout.Width + 2 * WallThickness;

        public decimal Breadth => BatteryCutout.Breadth + 2 * WallThickness;

        public decimal Height => BatteryCutout.Height + FloorThickness;

        public override string Render()
        {
            var box = new Box(Width, Breadth, Height, WallThickness, FloorThickness);

            return box.Render();
        }
    }
}

/*
const batteryDim = {
    width: 75.3,
    breadth: 36.8,
    height: 20
};

batteryDim.thickness = 2.25;
batteryDim.bumperHeight = batteryDim.height + pcaDim.thickness;
batteryDim.bumperWidth = batteryDim.width + 2 * pcaDim.thickness;
batteryDim.bumperBreadth = batteryDim.breadth + 2 * pcaDim.thickness;

const batteryBumper = () => {
    var thickness = batteryDim.thickness;
    var tol = 0.25;

    var box = new prim.cube()
        .width(batteryDim.bumperWidth - 2 * thickness)
        .breadth(batteryDim.bumperBreadth - 2 * thickness)
        .height(batteryDim.height);

    var outerBox = new prim.cube()
        .width(sharedBumperDim.width)
        .breadth(sharedBumperDim.breadth)
        .height(box.height() + thickness);

    console.log(`outerBox.width(): ${batteryDim.bumperWidth}`);

    var sideCutoutA = new prim.cube()
        .width(thickness)
        .breadth(14)
        .height(box.height());

    var sideCutoutB = new prim.cube()
        .width(thickness)
        .breadth(batteryDim.breadth - 15)
        .height(box.height());

    var sideCutoutC = new prim.cube()
        .width(outerBox.width() - 30)
        .breadth(outerBox.breadth())
        .height(box.height());

    return outerBox
        .subtract(
            box
                .union(sideCutoutA.clone().translate([outerBox.width() / 2 - sideCutoutB.width() / 2, sideCutoutA.breadth() / 2 - box.breadth() / 2, 0]))
                .union(sideCutoutA.clone().translate([outerBox.width() / 2 - sideCutoutB.width() / 2, box.breadth() / 2 - sideCutoutA.breadth() / 2, 0]))
                .union(sideCutoutB.clone().translate([sideCutoutB.width() / 2 - outerBox.width() / 2, 0, 0]))
                .union(sideCutoutC.clone())
                .translate([0, 0, outerBox.height() / 2 - box.height() / 2])
        );
};
*/