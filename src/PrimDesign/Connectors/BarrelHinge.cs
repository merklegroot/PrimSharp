using PrimSharp;

namespace PrimDesign.Connectors
{
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

        private readonly Cube Stick = new Cube
        {
            Width = 2 * innerHingeRadius,
            Breadth = StickLength,
            Height = innerHingeRadius
        };

        private IPrim OuterHinge()
        {
            var centerCutout = new Cylinder(outerHingeRadius, centerLength + cutoutTolerance);

            return new Cylinder(outerHingeRadius, hingeLength)
                .Union(Stick.TranslateY(-Stick.Breadth / 2).TranslateZ(-hingeLength / 2 + Stick.Width / 2))
                .Union(Stick.TranslateY(-Stick.Breadth / 2).TranslateZ(hingeLength / 2 - Stick.Width / 2))
                .Union(JoinerPlate.TranslateY(-(Stick.Breadth - JoinerPlate.Breadth / 2)))
                .Subtract(centerCutout)
                .Subtract(new Cylinder(innerCutoutRadius, hingeLength));
        }

        private IPrim InnerHinge()
        {
            var innerHinge = new Cylinder(innerHingeRadius, hingeLength);

            var stickWithPlate = Stick.Union(JoinerPlate.TranslateY(Stick.Breadth / 2 - JoinerPlate.Breadth / 2));

            return innerHinge.Union(stickWithPlate.TranslateY(Stick.Breadth / 2));
        }

        public override string ToOpenScad()
        {
            return OuterHinge().Union(InnerHinge()).ToOpenScad();
        }
    }
}
