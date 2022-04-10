using BuildingWorlds;
using Xunit;
using System;

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
    }
}