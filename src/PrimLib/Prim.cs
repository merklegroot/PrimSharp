namespace PrimLib
{
    public abstract class Prim : IPrim
    {
        public abstract string Render();

        public override string ToString() => Render();

        public virtual IPrim Union(IPrim b) => new PrimUnion(this, b);
        public virtual IPrim Subtract(IPrim b) => new PrimSubtraction(this, b);

        public virtual decimal[] Offset { get; private set; } = new decimal[3];
        public decimal OffsetX { get => Offset[0]; set => Offset[0] = value; }
        public decimal OffsetY { get => Offset[1]; set => Offset[1] = value; }
        public decimal OffsetZ { get => Offset[2]; set => Offset[2] = value; }

        public void Translate(decimal x, decimal y, decimal z) { OffsetX += x; OffsetY += y; OffsetZ += z; }
        public void Translate(decimal[] offset) { Offset[0] += offset[0]; Offset[1] += offset[1]; Offset[2] += offset[2]; }
    }
}