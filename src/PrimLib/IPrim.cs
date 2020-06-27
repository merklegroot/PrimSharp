namespace PrimLib
{
    public interface IPrim
    {
        string Render();
        IPrim Union(IPrim prim);
        IPrim Subtract(IPrim prim);

        decimal[] Offset { get; }
        decimal OffsetX { get; set; }
        decimal OffsetY { get; set; }
        decimal OffsetZ { get; set; }

        void Translate(decimal x, decimal y, decimal z);
        void Translate(decimal[] offset);
    }
}