using System;

namespace PrimSharp.Utils;

public static class LidExtensions
{
    public static ISizedPrim CutLid(this ISizedPrim source, decimal cutawaySize = 1.0m, decimal cutawayHeight = 1.5m)
    {
        var cutout = new Cube
        {
            Width = source.Width - 2 * cutawaySize,
            Breadth = source.Breadth - 2 * cutawaySize,
            Height = cutawayHeight
        };

        return source.Subtract(cutout);
    }

    private record Liddable : ISizedPrim
    {
        
    }
}
