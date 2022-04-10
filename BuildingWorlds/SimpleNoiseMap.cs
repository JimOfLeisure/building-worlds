namespace BuildingWorlds
{
    public class SimpleNoiseMap : IPositionToValue
    {
        private OpenSimplexNoise noise = new OpenSimplexNoise();
        double noiseScale = 0.007;
        public double Value(Position pos)
        {
            double value = noise.Evaluate(this.noiseScale * pos.X, this.noiseScale * pos.Y);
            // This noise generator returns from -1 to 1, normalize to 0 - 1
            value = (value + 1) / 2;
            return value;
        }
    }
}
