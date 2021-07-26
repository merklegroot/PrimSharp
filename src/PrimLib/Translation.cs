using System.Text;

namespace PrimLib
{
    public record Translation : Prim, ITranslation
    {
        private readonly IPrim _prim;

        public Translation(IPrim prim, decimal[] offset)
        {
            _prim = prim;
            Offset = offset;
        }

        public decimal[] Offset { get; private set; }

        public override string Render() =>
            new StringBuilder()
            .Append(_prim.Render())
            .Append($".translate([{Offset[0]}, {Offset[1]}, {Offset[2]}])")
            .ToString();
    }
}
