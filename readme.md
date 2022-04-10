# Building Worlds

Update: Returning to this after 3 months of inactivity, I'm currently
interested in poking at terrain generation but no longer care about
MonoGame. I may continue to use it to display a map just because
it's already there. Otherwise I'll use ImageSharp or something.

My goals for this project:

- Experiment with world map terrain generation

I may try to take some inspiration from <https://undiscoveredworlds.blogspot.com/>, but I'm doing
my own thing.

My current idea is to have a series of single-value generators that return a double based on position.
That value may represent height, humidity, temperature,
wind direction...whatever. And from those bits a
world map may emerge.

Pixels are irrelevant; scale is relative. Using double
precision floats for position and values.

I'm starting with a simple Simplex noise height map,
but I want to try layering hard-coded functions and
noise to force two-ish continents. It will be ugly
at first but evolve over time.

## Building

The word gen code is in BuildingWorlds/ . You can `dotnet build` in there or add a reference to another project.

BuildingWorlds.Tests/ is for running `dotnet test`; these aren't unit tests, but just me kicking the tires on my nascent world gen library.

## Credits

- OpenSimplexNoise.cs - Obtained from https://gist.github.com/digitalshadow/134a3a02b67cecd72181
  where it is in the public domain.
