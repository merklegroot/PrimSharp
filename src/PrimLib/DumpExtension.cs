using System;

namespace PrimLib
{
    public static class DumpExtension
    {
        public static string Dump(this object item)
        {
            var text = item.ToString();
            Console.WriteLine(text);

            return text;
        }
    }
}