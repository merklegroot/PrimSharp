using System;
using PrimSharp;

namespace PrimDesign.Spider;

public record PowerBox : Prim, ISizedPrim
{
    public decimal Width => throw new NotImplementedException();
    public decimal Breadth => throw new NotImplementedException();
    public decimal Height => throw new NotImplementedException();
    
    public decimal WallThickness { get; init; } = 1;

    public override string ToOpenScad()
    {
        var inlay = new SwitchInlay { WallThickness = WallThickness };
        
        return new Cube
        {
            Width = inlay.Width + 12,
            Breadth = inlay.Breadth + 8,
            Height = inlay.Height
        }
        .Subtract(inlay)
        .ToOpenScad();
    }
}
