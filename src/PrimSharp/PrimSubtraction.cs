using Newtonsoft.Json;

namespace PrimSharp
{
    public record PrimSubtraction : Prim
    {
        private readonly IPrim _a;
        private readonly IPrim _b;

        public PrimSubtraction(IPrim a, IPrim b) { _a = a; _b = b; }

        public override string Render() =>
            $"difference() {{ {_a.Render()} {_b.Render()} }}";
    }
}