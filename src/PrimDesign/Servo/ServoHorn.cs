using PrimSharp;
using System;

namespace PrimDesign.Servo;

public record ServoHorn : Prim
{
    /*
        var hornDim = function () {
            var majorDiscRadius = 3.5 + 0.1;
            var armMajor = 2 * majorDiscRadius;
            var armMinor = 4 + 0.2;
            var hornMinorDiscRadius = armMinor / 2;
            var armWidth = 20 - majorDiscRadius - hornMinorDiscRadius;
            var hornHeight = 4.2; //3.7; //2.5;

            var lowerDiscRadius = majorDiscRadius
            var lowerDiscHeight = 0.5;

            return {
                majorDiscRadius: majorDiscRadius,
                armMajor: armMajor,
                armMinor: armMinor,
                hornMinorDiscRadius: hornMinorDiscRadius,
                armWidth: armWidth,
                hornHeight: hornHeight,
                lowerDiscRadius: lowerDiscRadius,
                lowerDiscHeight: lowerDiscHeight
            };
        }();

    */


    public override string ToOpenScad()
    {
        throw new NotImplementedException();
    }
}