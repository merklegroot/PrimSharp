using System;
using System.Collections.Generic;

namespace PrimLib
{
    public class Bumper : Prim
    {
        private const decimal Width = 40;

        private const decimal Breadth = 20;

        private const decimal Height = 7.5m;

        public Bumper() { }

        public override string Render()
        {
            var box = new Box(Width, Breadth, Height);
            var cutoutHost = new Cube(Width, new NubbinCutout().Breadth, Height);

            IPrim result = box;

            result = result.Union(cutoutHost.Translate(0, Breadth / 2 + cutoutHost.Breadth / 2, 0));

            for (var i = 0; i < 4; i++)
            {
                var isLeft = i / 2 == 0;
                var isTop = i % 2 == 0;

                var nubbin = GetRotatedTranslatedNubbin(box, isLeft, isTop);
                result = isTop ? result.Subtract(nubbin) : result.Union(nubbin);
            }

            return result.Render();
        }

        private IPrim GetRotatedTranslatedNubbin(IHasSize box, bool isLeft, bool isTop)
        {
            var nub = isTop ? new NubbinCutout(box.Height) : new Nubbin(box.Height);

            return nub.RotateZ(180) //(!isTop ? nub.RotateZ(180) : (IPrim)nub)
                .Translate(
                    (isLeft ? 1 : -1) * (-box.Width / 2 + 1.5m * nub.Width),
                    (isTop ? 1 : -1) * (box.Breadth / 2 + nub.Breadth / 4 + (!isTop ? 0 : (new NubbinCutout().Breadth/2))),
                    0);
        }
    }
}
