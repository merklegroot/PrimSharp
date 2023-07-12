namespace PrimSharp;

public record PrimExtrusion : IRenderable
{
    public PrimExtrusion() { }

    public IPrim2d Shape { get; init; }

    public decimal Height { get; init; }

    public string ToOpenScad()
    {
        // linear_extrude(height = 5, center = true, convexity = 10, twist = -fanrot, slices = 20, scale = 1.0, $fn = 16) {...}
        return $"linear_extrude(height = {Height}, center = true) {{ {Shape.ToOpenScad()} }}";
    }
}