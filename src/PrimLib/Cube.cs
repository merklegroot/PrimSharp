using System;

namespace PrimLib
{
    public class Cube : Prim, IHasSize
    {
        public Cube() : this(1, 1, 1) { }
        public Cube(decimal[] size) : this(size[0], size[1], size[2]) { }
        public Cube(decimal w, decimal b, decimal h) { Width = w; Breadth = b; Height = h; }

        public decimal[] Size { get; private set; } = new decimal[3];
        public decimal Width { get => Size[0]; set => Size[0] = value; }
        public decimal Breadth { get => Size[1]; set => Size[1] = value; }
        public decimal Height { get => Size[2]; set => Size[2] = value; }

        public Cube Clone() => CloneAs<Cube>();

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

        public override string Render() => $"cube({{size: [{Width}, {Breadth}, {Height}], center: true}})";        
    }
}