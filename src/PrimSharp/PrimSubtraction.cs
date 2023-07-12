namespace PrimSharp;

public record PrimSubtraction : Prim
{
    private readonly IPrim _a;
    private readonly IPrim _b;

    public PrimSubtraction(IPrim a, IPrim b) { _a = a; _b = b; }

    public override string ToOpenScad() =>
        $"difference() {{ {_a.ToOpenScad()} {_b.ToOpenScad()} }}";
}