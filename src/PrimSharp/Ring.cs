namespace PrimSharp
{
    /// <summary>
    /// A hollow cylinder
    /// </summary>
    public record Ring : Cylinder
    {
        public decimal InnerRadius { get; init; }

        public override string ToOpenScad()
        {
            var innerCylinder = new Cylinder
            {
                Radius = InnerRadius,
                Height = Height
            };

            var outerCylinder = new Cylinder
            {
                Radius = Radius,
                Height = Height
            };

            return outerCylinder.Subtract(innerCylinder).ToOpenScad();
        }
    }
}