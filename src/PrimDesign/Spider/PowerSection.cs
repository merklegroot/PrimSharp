using PrimSharp;
using PrimSharp.Extensions;
using System;

namespace PrimDesign.Spider
{
    public record PowerSection : Prim
    {
        public override string Render()
        {
            var sizeableSwitchContainer = new SwitchContainer();

            // width stays the same, height and breadth swap
            // w, h, b
            // then
            // height stays the same, width and breadth swap
            // h, w, b
            var switchContainer = new SwitchContainer().RotateX(90).RotateZ(-90)
                .ManuallySize(sizeableSwitchContainer.Height, sizeableSwitchContainer.Width, sizeableSwitchContainer.Breadth);

            var splicerContainer = new SplicerContainer();

            var floorThickness = 1.0m;
            var distBetweenContainers = 10.0m;

            var sizeX = switchContainer.Width + splicerContainer.Width + distBetweenContainers;

            var sizeY = Math.Max(switchContainer.Breadth, splicerContainer.Breadth);
            var sizeZ = Math.Max(switchContainer.Height, splicerContainer.Height);

            var floor = new Cube(sizeX, sizeY + 10, floorThickness);

            return floor
                .Union(switchContainer
                    .TranslateX(switchContainer.Width / 2 - floor.Width / 2)
                    .TranslateZ(switchContainer.Height / 2 - floor.Height / 2))
                .Union(splicerContainer
                    .TranslateX(floor.Width / 2 - splicerContainer.Width / 2)
                    .TranslateZ(splicerContainer.Height / 2 - floor.Height / 2))
                .Render();
        }
    }
}
