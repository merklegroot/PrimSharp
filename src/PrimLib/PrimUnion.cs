using Newtonsoft.Json;

namespace PrimLib
{
    public class PrimUnion : Prim
    {
        private readonly IPrim _a;
        private readonly IPrim _b;

        public PrimUnion(IPrim a, IPrim b) { _a = a; _b = b; }

        public override string Render() => $"{_a.Render()}.union({_b.Render()})";
    }
}