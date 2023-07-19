namespace PrimSharp;

/// <summary>
/// A hollow box with a bottom but no top.
/// </summary>
public record Box : Cube
{
    private const decimal DefaultWallThickness = 1;
    private const decimal DefaultFloorThickness = 1;

    public decimal WallThickness { get; init; } = DefaultWallThickness;

    public decimal FloorThickness { get; init; } = DefaultFloorThickness;

    public Box() : this(1, 1, 1) { }

    public Box(decimal[] size) : this(size[0], size[1], size[2]) { }

    public Box(decimal width, decimal breadth, decimal height) : this(width, breadth, height, DefaultWallThickness, DefaultFloorThickness) { }

    public Box(decimal width, decimal breadth, decimal height, decimal wallThickness, decimal floorThickness)
        : base(width, breadth, height)
    {
        WallThickness = wallThickness;
        FloorThickness = floorThickness;
    }

    private Cube Cutout => new()
        {
            Width = Width - 2 * WallThickness,
            Breadth = Breadth - 2 * WallThickness,
            Height = Height - FloorThickness
        };

    private Cube Outer => new()
        {
            Width = Width,
            Breadth = Breadth,
            Height = Height
        };

    private IPrim Shape =>
        !Cutout.IsEmpty
            ? Outer.Subtract(Cutout.TranslateZ(FloorThickness / 2))
            : Outer;

    public override string ToOpenScad() => Shape.ToOpenScad();
}