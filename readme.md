# Building Worlds

My goals for this project:

- Get familiar with MonoGame
- Experiment with world map terrain generation
- Maybe integrate Ink narrator scripting system

I don't expect a completed game out of this project, but what does emerge might be
some hybrid of a 4X game and a visual novel. Pieces of this project my be
useful in future projects.

## Building

Uses .NET Core 3.1 SDK. You should be able to clone this repo and do a simple
`dotnet run` to fetch dependencies via Nuget and run it. I have the .NET 6
command line tools but had to also install the .NET Core 3.1 SDK separately
for MonoGame v3.8.

It is an 'mgdesktopgl' app, so it should work on Windows, Mac, and Linux
with an OpenGL capable video driver (which is pretty much all of them).
