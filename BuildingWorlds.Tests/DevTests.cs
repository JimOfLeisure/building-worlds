using BuildingWorlds;
using Xunit;
using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace BuildingWorlds.Tests
{
    public class DevTest
    {
        SimpleNoiseMap simpleMap = new SimpleNoiseMap();
        [Fact]
        public void Test1()
        {
            Console.WriteLine(simpleMap.Value(new Position(0.2, 0.2)));
        }
        [Fact]
        public void ImageOut()
        {
            string OutFilePath = "mapout.png";
            Rgba32 Blue = new Rgba32(0, 117, 119, 255);
            Rgba32 Green = new Rgba32(0, 128, 0, 255);
            Rgba32 Wheat = new Rgba32(245, 222, 179, 255);
            int width = 800;
            int height = 600;
            Image<Rgba32> ISImage = new Image<Rgba32>(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double value = simpleMap.Value(new Position(x, y));
                    if (value < 0.5)
                    {
                        ISImage[x, y] = Blue;
                    }
                    else if (value < 0.8)
                    {
                        ISImage[x, y] = Green;
                    }
                    else
                    {
                        ISImage[x, y] = Wheat;
                    }

                }
            }
            // Save as PNG
            using (FileStream fs = File.Create(OutFilePath))
            {
                ISImage.SaveAsPng(fs);
            }
        }
    }
}