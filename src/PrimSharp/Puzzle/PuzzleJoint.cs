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

    public decimal[] Size => new decimal[3] { Width, Breadth, Height };
    
    public bool HasNubbin { get; init; }

    private Cube Arm => new(JoinerThickness, JoinerLength, Height);

    private Cylinder Pip => new(Radius, Height);

    private IPrim PipMaybeWithNubbin =>
        HasNubbin
            ? Pip.Union(Nubbin.TranslateZ(-Pip.Height / 2 + Nubbin.Height / 2))
            : Pip;
    
    public PuzzleJoint() : this(DefaultHeight) { }

    public PuzzleJoint(decimal height) => Height = height;

    private IPrim Shape =>
        Arm.TranslateY(JoinerLength / 2)
            .Union(PipMaybeWithNubbin.TranslateY(JoinerLength))
            .TranslateY(-Breadth / 2);

    private Cylinder Nubbin => new()
    {
        Radius = Pip.Radius + 0.25m,
        Height = 1
    };

    public override string ToOpenScad() => Shape.ToOpenScad();
}