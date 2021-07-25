using PrimLib;

namespace PrimDesignLib.Servo
{
    public class ServoHornPeg : Prim
    {
        // public ServoHornPeg() : base(3.6m, 4.2m, 2.1m) { }
        public override string Render()
        {
            // var outer = new Cylinder();
            var outer = new HollowCylinder(3.6m, 4.2m, 2.1m);

            // throw new System.NotImplementedException();

            return outer.Render();
        }
    }
}
