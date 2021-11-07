namespace PrimSharp
{
    public interface IPrim
    {
        /// <summary>
        /// Converts the primitive to OpenSCAD code.
        /// </summary>
        /// <returns>Code that can be rendered by OpenSCAD.</returns>
        string ToOpenScad();

        /// <summary>
        /// Combine the primitive with another primitive.
        /// </summary>
        IPrim Union(IPrim prim);

        /// <summary>
        /// Subtracts a primitive.
        /// </summary>
        IPrim Subtract(IPrim prim);

        /// <summary>
        /// Translates the primitive.
        /// </summary>
        IPrim Translate(decimal x, decimal y, decimal z);

        IPrim TranslateX(decimal offset);

        IPrim TranslateY(decimal offset);

        IPrim TranslateZ(decimal offset);

        IPrim Translate(decimal[] offset);

        IRotation RotateX(decimal angle);

        IRotation RotateY(decimal angle);

        IRotation RotateZ(decimal angle);

        IRotation Rotate(int axis, decimal angle);
    }
}