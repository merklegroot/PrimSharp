namespace PrimLib
{
    public interface IRotation : IPrim
    {
        int Axis { get;  }

        decimal Angle { get; }
    }
}
