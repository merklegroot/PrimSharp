namespace PrimSharp
{
    public interface ISize2d
    {
        decimal Width { get; }

        decimal Breadth { get; }

        decimal[] Size => new decimal[] { Width, Breadth };
    }
}
