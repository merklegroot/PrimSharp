namespace PrimLib
{
    public class NubbinCutout : Nubbin
    {
        public NubbinCutout() { }
        public NubbinCutout(decimal height) : base(height) { }

        protected override decimal Radius => 1.2m * base.Radius;

        protected override decimal JoinerThickness => 1.25m * base.Radius;
    }
}
