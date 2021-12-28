using System;
using System.Collections.Generic;

namespace PrimSharp
{
    public class Sector2d : IRenderable, ISize2d, IPrim2d
    {
        public decimal Radius { get; init; } = 1;

        public int Resolution { get; init; } = 100;

        public decimal AngleRadians { get; init; } = 30.0m;

        public decimal Width => 2.0m * Radius;

        public decimal Breadth => 2.0m * Radius;

        public string ToOpenScad()
        {
            var circle = new Circle { Radius = Radius, Resolution = Resolution };

            var arcLength = Math.Sqrt((double)(2.0m * Radius * Radius));

            var cutout = new Polygon
            {
                Points = new List<Point2d>
                {
                    new Point2d(0, 0),
                    new Point2d((decimal)arcLength, 0),
                    new Point2d((decimal)arcLength * (decimal)Math.Cos((double)AngleRadians), (decimal)arcLength * (decimal)Math.Sin((double)AngleRadians))
                }
            };

            return circle
                .Subtract(cutout)
                .ToOpenScad();
        }
    }
}
