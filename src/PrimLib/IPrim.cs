namespace PrimLib
{
    public interface IPrim
    {
        string Render();

        IPrim Union(IPrim prim);

        IPrim Subtract(IPrim prim);

        IPrim Translate(decimal x, decimal y, decimal z);

        IPrim Translate(decimal[] offset);

        IRotation RotateX(decimal angle);

        IRotation RotateY(decimal angle);

        IRotation RotateZ(decimal angle);

        IRotation Rotate(int axis, decimal angle);
    }
}