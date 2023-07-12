namespace PrimSharp;

public record PrimUnion : Prim
{
    private readonly IPrim _a;
    private readonly IPrim _b;

    public PrimUnion(IPrim a, IPrim b) { _a = a; _b = b; }

    public override string ToOpenScad() =>
        $"union() {{ {_a.ToOpenScad()} {_b.ToOpenScad()} }}";
}