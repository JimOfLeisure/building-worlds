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
        private OpenSimplexNoise noise = new OpenSimplexNoise();
        double noiseScale = 0.02;
        public void Initialize(GraphicsDevice device)
        {
            foo = CreateTexture(device, 100, 100, pixel => Color.Gray);
            width = 400;
            foo = CreateTexture(device, width, 400, NoiseMap);
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
            // float divisor = 10000;
            // return new Color(pixel / divisor, pixel / divisor, pixel / divisor, (float)1.0);
            float value = (float)noise.Evaluate(noiseScale * (pixel % this.width), this.noiseScale * Math.Floor((double)(pixel / width)));
            return new Color(value, value, value, (float)1.0);
        }
    }
}
