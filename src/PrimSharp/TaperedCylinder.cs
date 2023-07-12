namespace PrimSharp;

public record TaperedCylinder : Cylinder
{
    public decimal MinorRadius { get; init; }

    public override string ToOpenScad() =>
        MinorRadius == Radius
            ? base.ToOpenScad()
            : $"cylinder(h={Height}, r1={Radius}, r2={MinorRadius}, $fn={Resolution}, center=true);";
}