namespace PrimSharp
{
    public interface ISize
    {
        decimal Width { get; }

        decimal Breadth { get; }

        decimal Height { get; }

        decimal[] Size => new decimal[] { Width, Breadth, Height };
    }
}
