namespace PrimLib
{
    public class HollowCylinder : Cylinder
    {
        public decimal InnerRadius { get; set; }

        public HollowCylinder(decimal radius, decimal height, decimal innerRadius) : base(radius, height) =>
            InnerRadius = innerRadius;

        public override string Render() =>
            Subtract(new Cylinder { Height = Height, Radius = InnerRadius, Resolution = Resolution })
            .Render();
    }
}
