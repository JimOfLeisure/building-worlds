using BuildingWorlds.External;
using System;

namespace BuildingWorlds.Core
{
    class Foo
    {
        private int width;
        private int height;
        private OpenSimplexNoise noise = new OpenSimplexNoise();
        double noiseScale = 0.007;
        // Temp hack to delete MonoGame and keep this around for refrence
        public enum Color
        {
            Blue,
            Green,
            Wheat,
        }

        public Color NoiseMap(int pixel)
        {
            float value = (float)noise.Evaluate(noiseScale * (pixel % this.width), this.noiseScale * Math.Floor((double)(pixel / width)));
            // This noise generator returns from -1 to 1, normalize to 0 - 1
            value = (value + 1) / 2;
            if (value < 0.5) return Color.Blue;
            if (value < 0.8) return Color.Green;
            return Color.Wheat;
        }
    }
}
