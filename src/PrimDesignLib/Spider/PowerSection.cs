using PrimLib;

namespace PrimDesignLib.Spider
{
    public class PowerSection : Prim, ISizedPrim
    {
        public decimal Width => 40;

        public decimal Breadth => 30;

        public decimal Height => 10;

        public override string Render()
        {
            throw new System.NotImplementedException();
        }
    }
}
