namespace PrimSharp.Extensions
{
    public static class PrimExtensions
    {
        public static ManuallySized ManuallySize(this IPrim prim, decimal[] size) =>
            prim.ManuallySize(size[0], size[1], size[2]);

        public static ManuallySized ManuallySize(this IPrim prim, decimal width, decimal breadth, decimal height)
            => new ManuallySized(prim, width, breadth, height);

        public static ManuallySized Stack(this ISizedPrim a, ISizedPrim b, int axis = 2, bool dontRecenter = false)
        {
            var vector = new decimal[3];
            vector[axis] = a.Size[axis] / 2 + b.Size[axis] / 2;

            var size = new decimal[] { a.Size[0], a.Size[1], a.Size[2] };
            size[axis] += b.Size[axis];

            var result = a.Union(b.Translate(vector));
            if (!dontRecenter)
            {
                var recenterVector = new decimal[3];
                recenterVector[axis] = (a.Size[axis] / 2) - ((a.Size[axis] + b.Size[axis]) / 2);

                result = result.Translate(recenterVector);
            }

            return result.ManuallySize(size);
        }
    }
}
