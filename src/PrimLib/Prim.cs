using Newtonsoft.Json;

namespace PrimLib
{
    public abstract record Prim : IPrim
    {
        public virtual IPrim Union(IPrim b) => new PrimUnion(this, b);
        public virtual IPrim Subtract(IPrim b) => new PrimSubtraction(this, b);

        public IPrim Translate(decimal x, decimal y, decimal z) => Translate(new decimal[] {x, y, z});

        public IPrim Translate(decimal[] offset) =>new Translation(this, offset);

        public IPrim TranslateX(decimal offset) => Translate(offset, 0, 0);

        public IPrim TranslateY(decimal offset) => Translate(0, offset, 0);

        public IPrim TranslateZ(decimal offset) => Translate(0, 0, offset);

        protected TSelf CloneAs<TSelf>() => JsonConvert.DeserializeObject<TSelf>(JsonConvert.SerializeObject(this));

        public override string ToString() => Render();

        public abstract string Render();

        public IRotation RotateX(decimal angle) => 
            new Rotation(this, 0, angle);

        public IRotation RotateY(decimal angle) =>
            new Rotation(this, 1, angle);

        public IRotation RotateZ(decimal angle) =>
            new Rotation(this, 2, angle);

        public IRotation Rotate(int axis, decimal angle) =>
            new Rotation(this, axis, angle);
    }
}