using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace building_worlds
{
    class Foo
    {
        Texture2D foo;
        private int width;
        private int height;
        private OpenSimplexNoise noise = new OpenSimplexNoise();
        double noiseScale = 0.007;
        public void Initialize(GraphicsDevice device)
        {
            foo = CreateTexture(device, 100, 100, pixel => Color.Gray);
            this.width = 800;
            this.height = 480;
            foo = CreateTexture(device, width, height, NoiseMap);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(foo, Vector2.Zero, Color.White);
            spriteBatch.End();
        }
        public static Texture2D CreateTexture(GraphicsDevice device, int width,int height, Func<int,Color> paint)
        {
            //initialize a texture
            Texture2D texture = new Texture2D(device, width, height);

            //the array holds the color for each pixel in the texture
            Color[] data = new Color[width * height];
            for(int pixel=0;pixel<data.Length;pixel++)
            {
                //the function applies the color according to the specified pixel
                data[pixel] = paint(pixel);
            }

            //set the color
            texture.SetData(data);

            return texture;
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
