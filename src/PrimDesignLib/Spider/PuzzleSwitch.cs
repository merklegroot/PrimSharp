using PrimLib;

namespace PrimDesignLib
{
    public record PuzzleSwitch : Prim
    {
        public override string Render()
        {
            const decimal BumperBreadth = 30;

            var bumper = new Bumper(BumperBreadth);
            var switchContainer = new SwitchContainer();
            var splicerContainer = new SplicerContainer();

            return bumper.TranslateZ(bumper.Height / 2)
                .Union(switchContainer.TranslateZ(switchContainer.Height / 2 + bumper.Height / 2).TranslateX(bumper.Width / 4))
                .Union(splicerContainer.TranslateZ(splicerContainer.Height / 2 + bumper.Height / 2).TranslateX(-bumper.Width / 4))

                .Render();
        }
    }
}
