﻿using System;
using PrimSharp;

namespace PrimDesign.Servo;

public record ServoHornPeg : Prim
{
    // public ServoHornPeg() : base(3.6m, 4.2m, 2.1m) { }
    public override string ToOpenScad()
    {
        // var outer = new Cylinder();
        // var outer = new HollowCylinder(3.6m, 4.2m, 2.1m);

        // return outer.Render();

        throw new NotImplementedException();
    }
}