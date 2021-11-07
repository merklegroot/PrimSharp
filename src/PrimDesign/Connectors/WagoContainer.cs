using PrimSharp;

namespace PrimDesign.Containers
{
    /// <summary>Just a box that fits a 4 pin wago connector</summary>
    public record WagoContainer : Box
    {       
        private const decimal ContainerWallThickness = 1.0m;
        private const decimal ContainerFloorThickness = 1.0m;

        private const decimal Tol = 0.2m;

        private const decimal WagoWidth = 22;

        private const decimal WagoBreadth = 14.42m;

        private const decimal WagoHeight = 21;

        public WagoContainer() : base(
            WagoWidth + 2 * Tol + 2 * ContainerWallThickness, 
            WagoBreadth + 2 * Tol + 2 * ContainerWallThickness,
            WagoHeight + ContainerFloorThickness)
        { }
    }
}