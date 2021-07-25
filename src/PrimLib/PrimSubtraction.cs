using Newtonsoft.Json;

namespace PrimLib
{
    public class PrimSubtraction : Prim
    {
        private readonly IPrim _a;
        private readonly IPrim _b;

        public PrimSubtraction(IPrim a, IPrim b) { _a = a; _b = b; }

        public override string Render() => $"{_a.Render()}.subtract({_b.Render()})";
    }
}