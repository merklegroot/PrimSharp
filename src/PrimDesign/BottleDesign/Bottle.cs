using PrimSharp;
using PrimSharp.Extensions;

namespace PrimDesign.BottleDesign;

public record Bottle : Prim
{
    private static readonly decimal MajorRadius = 1.25m.Inch();
    private static readonly decimal MinorRadius = 0.5m.Inch();
    private static readonly decimal FullHeight = 8.0m.Inch();
    private static readonly decimal MinorHeight = 2.0m.Inch();
    private static readonly decimal MajorHeight = FullHeight - MinorHeight;

    public decimal Height => FullHeight;

    private Cylinder MajorCylinder => new Cylinder
    {
        Radius = MajorRadius,
        Height = MajorHeight
    };

    private TaperedCylinder MinorCylinder = new TaperedCylinder
    {
        Radius = MajorRadius,
        MinorRadius = MinorRadius,
        Height = MinorHeight
    };

    //private object MinorCylinderWithCap = Min

    private static readonly decimal CapHeight = 17;
    private static readonly decimal CapRadius = MinorRadius + 9;

    private Cylinder Cap = new Cylinder
    {
        Radius = CapRadius,
        Height = CapHeight
    };

    public override string ToOpenScad()
    {            
        var stacked = MajorCylinder
            .Stack(MinorCylinder);
                
        return stacked
            .Union(Cap.TranslateZ(stacked.Height / 2 - Cap.Height / 2))
            .ToOpenScad();
    }
}