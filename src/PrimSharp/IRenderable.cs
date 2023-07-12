namespace PrimSharp;

public interface IRenderable
{
    /// <summary>
    /// Converts the primitive to OpenSCAD code.
    /// </summary>
    /// <returns>Code that can be rendered by OpenSCAD.</returns>
    string ToOpenScad();
}