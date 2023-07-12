namespace PrimSharp;

public record Cylinder : Prim, ISizedPrim
{
    private const decimal DefaultRadius = 0.5m;

    private const decimal DefaultHeight = 1.0m;

    private const int DefaultResolution = 100;

    public Cylinder() : this(DefaultRadius, DefaultHeight) { }
        
    public Cylinder(decimal radius) : this(radius, DefaultHeight) { }

    public Cylinder(decimal? radius, decimal? height) { Radius = radius ?? DefaultRadius; Height = height ?? DefaultHeight; }

    public decimal Radius { get; init; }
        
    public decimal Height { get; init; }

    public int Resolution { get; init; } = DefaultResolution;

    public decimal Width => 2.0m * Radius;

    public decimal Breadth => 2.0m * Radius;

    public override string ToOpenScad() =>
        $"cylinder(h={Height}, r={Radius}, $fn={Resolution}, center=true);";
}