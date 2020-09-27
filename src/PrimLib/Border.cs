using System;
using System.Collections.Generic;
using System.Text;

namespace PrimLib
{
    public class Border : Prim, ISizedPrim
    {
        private const decimal DefaultWallThickness = 1;

        public Border() : this(1, 1, 1) { }
        public Border(decimal[] size) : this(size[0], size[1], size[2]) { }
        public Border(decimal w, decimal b, decimal h) : this(w, b, h, DefaultWallThickness) { }

        public Border(decimal w, decimal b, decimal h, decimal wallThickness) { Width = w; Breadth = b; Height = h; WallThickness = wallThickness; }

        public decimal Width { get; set; }
        public decimal Breadth { get; set; }
        public decimal Height { get; set; }

        public decimal WallThickness { get; set; }

        public override string Render() =>
            CloneAs<Cube>().Subtract(GenerateCutout()).Render();

        private IPrim GenerateCutout() => new Cube(Width - 2 * WallThickness, Breadth - 2 * WallThickness, Height);

    }
}
