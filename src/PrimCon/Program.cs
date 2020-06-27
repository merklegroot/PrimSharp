using System;

namespace PrimCon
{
    class Program
    {
        static void Main(string[] args) => AppFactory().Run();

        private static App AppFactory() => new App();
    }
}
