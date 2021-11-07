using System.Text;

namespace PrimSharp
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
                .AppendLine($"translate([{Offset[0]}, {Offset[1]}, {Offset[2]}]) {{")
                .AppendLine(_prim.Render())
                .AppendLine("}")
                .ToString();
    }
}
