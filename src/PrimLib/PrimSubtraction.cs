using Newtonsoft.Json;

namespace PrimLib
{
    public record PrimSubtraction : Prim
    {
        private readonly IPrim _a;
        private readonly IPrim _b;

        public PrimSubtraction(IPrim a, IPrim b) { _a = a; _b = b; }

        public override string Render() =>
            $"subtract() {{ {_a.Render()} {_b.Render()} }}";
    }
}