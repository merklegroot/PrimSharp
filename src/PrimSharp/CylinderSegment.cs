namespace PrimSharp
{
    public record CylinderSegment : Cylinder
    {
        private const decimal DefaultaPortion = 1.0m;
        private decimal _portion;

        public CylinderSegment(decimal? radius, decimal? height, decimal? portion) : base(radius, height)
        {
            _portion = portion ?? DefaultaPortion;
        }

        public override string ToOpenScad()
        {
            return base.ToOpenScad();
        }
    }
}
