namespace PrimSharp.Puzzle;

public record PuzzleJoint : Prim, ISize
{
    private const decimal DefaultHeight = 1;

    private const decimal DefaultRadius = 1.5m;

    protected virtual decimal Radius => DefaultRadius;

    protected virtual decimal JoinerLength => 1.55m * Radius;

    protected virtual decimal JoinerThickness => Radius;

    public decimal Height { get; init; } = DefaultHeight;

    public decimal Width => 2 * Radius;

    public decimal Breadth => JoinerLength + Radius;

    public decimal[] Size => new[] { Width, Breadth, Height };

    public decimal? NubbinHeight { get; init; }
    
    public decimal? NubbinAdditionalRadius { get; init; }
    
    public bool IsNubbinTapered { get; init; }

    private Cube Arm => new(JoinerThickness, JoinerLength, Height);

    private Cylinder Pip => new(Radius, Height);

    private IPrim PipMaybeWithNubbin =>
        NubbinHeight.HasValue && NubbinHeight.Value != default
            ? Pip.Union(Nubbin.TranslateZ(-Pip.Height / 2 + Nubbin.Height / 2))
            : Pip;

    private IPrim Shape =>
        Arm.TranslateY(JoinerLength / 2)
            .Union(PipMaybeWithNubbin.TranslateY(JoinerLength))
            .TranslateY(-Breadth / 2);

    private Cylinder Nubbin => new()
    {
        Radius = Pip.Radius + (IsNubbinTapered ? 0 : NubbinAdditionalRadius ?? 0),
        Radius2 = Pip.Radius + (NubbinAdditionalRadius ?? 0),
        Height = NubbinHeight ?? 0
    };

    public override string ToOpenScad() => Shape.ToOpenScad();
}