namespace PrimSharp;

public record Lid : Prim, ISizedPrim
{
    public decimal Width { get; }
    public decimal Breadth { get; }
    public decimal Height { get; }
    
    public override string ToOpenScad()
    {
        throw new System.NotImplementedException();
    }

}
