namespace PrimSharp
{
    public static class Prim2dExtensions
    {
        public static PrimExtrusion Extrude(this IPrim2d source, decimal height) => 
            new PrimExtrusion
            {
                Shape = source,
                Height = height
            };
    }
}
