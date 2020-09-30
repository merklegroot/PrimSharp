using PrimLib;
using System;

namespace PrimDesignLib.Spider
{
    public class PowerSection : Prim
    {
        public override string Render()
        {
            var sizeableSwitchContainer = new SwitchContainer();

            var switchContainer = new SwitchContainer().RotateX(90).ManuallySize(sizeableSwitchContainer.Width, sizeableSwitchContainer.Height, sizeableSwitchContainer.Breadth);
            var splicerContainer = new SplicerContainer();

            var distBetweenContainers = 10.0m;

            var fullWidth = switchContainer.Width + splicerContainer.Width + distBetweenContainers;
            var fullBreadth = Math.Max(switchContainer.Breadth, splicerContainer.Breadth);
            var fullHeight = Math.Max(switchContainer.Height, splicerContainer.Height);

            var floorThickness = 1.0m;

            var floor = new Cube(fullWidth, fullBreadth, floorThickness);

            return switchContainer
                .TranslateZ(switchContainer.Height / 2)
                .TranslateX(-switchContainer.Width / 2 - distBetweenContainers / 2)
                .TranslateY(switchContainer.Breadth /2)
                .Union(
                    splicerContainer
                    .TranslateZ(splicerContainer.Height / 2)
                    .TranslateX(splicerContainer.Width / 2 + 2 / distBetweenContainers)
                    .TranslateY(splicerContainer.Breadth / 2)
                )
                .Union(floor)
                .Render();
        }
    }
}
