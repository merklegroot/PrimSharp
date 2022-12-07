using System;
using System.Collections.Generic;

namespace PrimSharp;

public record Polyhedron : Prim
{
    public List<List<Point3d>> Points { get; init; }
    
    public List<Point3d> Faces { get; init; }
    
    public override string ToOpenScad()
    {
        // polyhedron(points, [[0,2,1], [0,1,3], [1,2,3], [0,3,2]]);

        throw new NotImplementedException();
        // return $"polyhedron({}, {})";
    }

    private string RenderGroup<T>(List<T> group) =>
        // $"[{string.Join(", ")}]";
        throw new NotImplementedException();
}