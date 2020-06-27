using System;
using Newtonsoft.Json;

namespace PrimLib
{
    public class Cube : Prim
    {
        public Cube() : this(1, 1, 1) { }
        public Cube(decimal[] size) : this(size[0], size[1], size[2]) { }
        public Cube(decimal[] size, decimal[] offset) : this(size[0], size[1], size[2], offset[0], offset[1], offset[2]) { }
        public Cube(decimal w, decimal b, decimal h) : this(w, b, h, 0, 0, 0) { }
        public Cube(decimal w, decimal b, decimal h, decimal x, decimal y, decimal z)
        {
            Width = w; Breadth = b; Height = h;
            OffsetX = x; OffsetY = y; OffsetZ = z;
        }

        public decimal[] Size { get; private set; } = new decimal[3];

        public decimal Width { get => Size[0]; set => Size[0] = value; }
        public decimal Breadth { get => Size[1]; set => Size[1] = value; }
        public decimal Height { get => Size[2]; set => Size[2] = value; }

        public override string Render() => RenderSolid() + (HasOffset ? TranslationClause() : string.Empty);

        public Cube Clone() => (Cube)JsonConvert.DeserializeObject<Cube>(JsonConvert.SerializeObject(this));

        public IPrim AsBox() => AsBox(1);

        public IPrim AsBox(decimal thickness) => AsBox(thickness, thickness);

        public IPrim AsBox(decimal wallThickness, decimal floorThickness) => Subtract(new Func<IPrim>(() =>
            {
                var inner = Clone();
                inner.Width = Width - 2 * wallThickness;
                inner.Breadth = Breadth - 2 * wallThickness;
                inner.Height = Height - floorThickness;
                inner.Translate(0, 0, Height / 2 - inner.Height / 2);

                return inner;
            })());

        private bool HasOffset => OffsetX != 0 || OffsetY != 0 || OffsetZ != 0;

        private string RenderSolid() => $"cube({{size: [{Width}, {Breadth}, {Height}], center: true}})";
        private string TranslationClause() => $".translate([{OffsetX}, {OffsetY}, {OffsetZ}])";
    }
}