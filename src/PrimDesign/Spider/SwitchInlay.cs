using PrimSharp;

namespace PrimDesign.Spider;

public record SwitchInlay : Prim, ISizedPrim
{
    private decimal NubbinDiameter = 3.75m; // measured: 3.58m;
    private decimal NubbinHeight = 3.19m;
    
    public decimal Width => InlayWidth;
    public decimal Breadth => InlayBreadth;
    public decimal Height => WallThickness;

    private const decimal ScrewDist = 38.92m;

    private const decimal InlayWidth = 34.5m; //33.62m;
    private const decimal InlayBreadth = 15.5m; // 15.35m;
    
    public decimal WallThickness { get; init; } = 1;

    private const decimal ScrewHoleDiameter = 2.0m; //1.75m;
    private const decimal ScrewHoleRadius = ScrewHoleDiameter / 2.0m;

    public override string ToOpenScad()
    {
        var screwHole = new Cylinder
        {
            Radius = ScrewHoleRadius,
            Height = WallThickness
        };

        var nubbinCutout = new Cylinder
        {
            Radius = NubbinDiameter / 2.0m,
            Height = NubbinHeight
        };

        var nubbin = new Cylinder
        {
            Radius = nubbinCutout.Radius + 0.5m,
            Height = nubbinCutout.Height + 0.5m
        };
        
        var inlay = new Cube
        {
            Width = InlayWidth,
            Breadth = InlayBreadth,
            Height = WallThickness
        };

        return inlay
            .Union(screwHole.TranslateX(ScrewDist / 2.0m))
            .Union(screwHole.TranslateX(-ScrewDist / 2.0m))
            .ToOpenScad();
    }
}