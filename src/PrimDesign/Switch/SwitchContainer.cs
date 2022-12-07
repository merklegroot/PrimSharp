using PrimSharp;

namespace PrimDesign.Switch;

public record SwitchContainer : Prim
{
    private const decimal SwitchBreadth = 11.65m;
    private const decimal SwitchWidth = 19.0m;
    private const decimal Thickness = 1.0m;

    private const decimal EdgeSize = 5.0m;

    private const decimal ContainerWidth = SwitchWidth + EdgeSize;
    private const decimal ContainerBreadth = SwitchBreadth + EdgeSize;

    private const decimal ContainerDepth = 20;
    
    public override string ToOpenScad()
    {
        var container = new Cube { Width = ContainerWidth, Breadth = ContainerBreadth, Height = ContainerDepth };
        var containerCutout = new Cube { Width = ContainerWidth - Thickness, Breadth = ContainerBreadth - Thickness, Height = ContainerDepth - Thickness };

        var containerWithCutout = container
            .Subtract(containerCutout.TranslateX(Thickness / 2));

        return containerWithCutout.ToOpenScad();
        
        // return new Cube { Width = SwitchWidth + 5, Breadth = SwitchBreadth + 5, Height = Thickness }
        //     .Subtract(new Cube { Width = SwitchWidth, Breadth = SwitchBreadth, Height = Thickness })
        //     .ToOpenScad();
    }
}
