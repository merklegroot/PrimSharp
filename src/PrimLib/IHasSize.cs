namespace PrimLib
{
    public interface IHasSize
    {
        decimal Width { get; }

        decimal Breadth { get; }

        decimal Height { get; }

        decimal[] Size { get; }
    }
}
