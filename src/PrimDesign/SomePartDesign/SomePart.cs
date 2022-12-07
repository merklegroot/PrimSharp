using System;
using PrimSharp;

namespace PrimDesign.SomePartDesign
{
    public record SomePart : Prim
    {       
        public override string ToOpenScad()
        {
            var outerRadius = 31.08m / 2.0m;
            var innerRadius = 25.44m / 2.0m;
            var height = 30.0m;
            var width = 22.0m + (31.08m / 2.0m);
            var boreRadius = 5.50m / 2.0m;
            var ringRoofHeight = 2.5m;
            
            var block = new Cube
            {
                Width = width,
                Breadth = 2 * outerRadius,
                Height = height
            };
            
            var ringPart = new Cylinder
            {
                Radius = outerRadius,
                Height = height
            };

            var ringCutout = new Cylinder
            {
                Radius = innerRadius,
                Height = height - ringRoofHeight
            };

            var bore = new Cylinder
            {
                Radius = boreRadius,
                Height = 100
            };

            return ringPart
                .Union(block.TranslateX(block.Width / 2.0m))
                .Subtract(ringCutout.TranslateZ(ringCutout.Height / 2.0m - ringPart.Height / 2.0m))
                .Subtract(bore.RotateY(90).TranslateX(bore.Height / 2.0m + ringPart.Radius + 5))
                .ToOpenScad();
        }
    }
}