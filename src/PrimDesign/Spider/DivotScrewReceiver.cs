using System;
using PrimSharp;

namespace PrimDesign.Spider;

public record DivotScrewReceiver : Prim, ISizedPrim
{
    public decimal Width => 2.0m * PrimaryRadius;
    public decimal Breadth => 2.0m * PrimaryRadius;
    public decimal Height => PrimaryHeight;

    private const decimal PrimaryRadius = 2.0m;
    private const decimal PrimaryHeight = 4;

    private const decimal InlayRadius = 1.0m;
    private const decimal InlayHeight = 2.0m;

    private const decimal ScrewRadius = 0.5m;
    private const decimal ScrewHeight = 0.4m;
    
    
    public override string ToOpenScad()
    {
        var primaryCylinder = new Cylinder
        {
            Radius = PrimaryRadius,
            Height = PrimaryHeight
        };

        var topSectionInlay = new Cylinder
        {
            Radius = InlayRadius,
            Height = InlayHeight
        };
        
        var screwInlay = new Cylinder
        {
            Radius = ScrewRadius,
            Height = ScrewHeight
        };

        return primaryCylinder
            .Subtract(
                topSectionInlay
                .TranslateZ(primaryCylinder.Height / 2.0m - topSectionInlay.Height / 2.0m)
            )
            .Subtract(screwInlay
                .TranslateZ(primaryCylinder.Height / 2.0m - topSectionInlay.Height - ScrewHeight / 2.0m)    
            )
            .Subtract(new Cube{Width = 2 * PrimaryRadius, Breadth = 2 * PrimaryRadius, Height = PrimaryHeight}
                .TranslateX(PrimaryRadius))
            .ToOpenScad();
    }
}
