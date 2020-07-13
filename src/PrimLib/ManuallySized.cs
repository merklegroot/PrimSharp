namespace PrimLib
{
    public class ManuallySized : Prim, ISizedPrim
    {
        private readonly IPrim _prim;

        public ManuallySized(IPrim prim, decimal width, decimal breadth, decimal height)
        {
            _prim = prim;
            Width = width; Breadth = breadth; Height = height;
        }

        public decimal Width { get; private set; }

        public decimal Breadth { get; private set; }

        public decimal Height { get; private set; }

        public decimal[] Size => new decimal[] { Width, Breadth, Height };

        public override string Render() => _prim.Render();
    }
}
