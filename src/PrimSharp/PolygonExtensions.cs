namespace PrimSharp
{
    public static class PolygonExtensions
    {
        public static ExtrudedPolygon Extrude(this Polygon source, decimal height) =>
            new ExtrudedPolygon { Height = height, Points = source.Points };
    }
}
