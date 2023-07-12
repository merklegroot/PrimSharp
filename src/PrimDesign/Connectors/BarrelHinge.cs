using PrimSharp;

namespace PrimDesign.Connectors;

public record BarrelHinge : Prim
{
    private const decimal cutoutTolerance = 0.2m;

    private const decimal hingeLength = 4;
    private const decimal outerHingeRadius = 4;
    private const decimal innerHingeRadius = 2;
    private const decimal innerCutoutRadius = innerHingeRadius + cutoutTolerance;
    private const decimal centerLength = hingeLength / 2;

    private const decimal StickLength = 2.5m * outerHingeRadius;

    private readonly Cube JoinerPlate = new Cube
    {
        Width = 2 * outerHingeRadius,
        Breadth = innerHingeRadius,
        Height = hingeLength
    };

    private readonly Cube InnerStick = new Cube
    {
        Width = 2 * innerHingeRadius,
        Breadth = StickLength,
        Height = innerHingeRadius
    };

    private readonly Cube OuterStick = new Cube
    {
        Width = 2 * innerHingeRadius,
        Breadth = StickLength,
        Height = outerHingeRadius
    };

    private IPrim OuterHinge()
    {
        var centerCutout = new Cylinder(outerHingeRadius, centerLength + cutoutTolerance);

        return new Cylinder(outerHingeRadius, hingeLength)
            .Subtract(centerCutout)
            .Union(OuterStick.TranslateY(-OuterStick.Breadth / 2).TranslateZ(-hingeLength / 2 + OuterStick.Width / 2))
            .Union(JoinerPlate.TranslateY(-(OuterStick.Breadth - JoinerPlate.Breadth / 2)))
                
            .Subtract(new Cylinder(innerCutoutRadius, hingeLength));
    }

    private IPrim InnerHinge()
    {
        var innerHinge = new Cylinder(innerHingeRadius, hingeLength);

        var stickWithPlate = InnerStick.Union(JoinerPlate.TranslateY(InnerStick.Breadth / 2 - JoinerPlate.Breadth / 2));

        return innerHinge.Union(stickWithPlate.TranslateY(InnerStick.Breadth / 2));
    }

    public override string ToOpenScad()
    {
        return OuterHinge().Union(InnerHinge()).ToOpenScad();
    }
}