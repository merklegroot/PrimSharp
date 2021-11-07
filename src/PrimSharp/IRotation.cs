namespace PrimSharp
{
    public interface IRotation : IPrim
    {
        int Axis { get;  }

        decimal Angle { get; }
    }
}
