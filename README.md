# Dotnet3DEngineFromScratch

## Table of contents

* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Controls](#controls)
  * [General](#general)
  * [Moving mode](#moving-mode)
  * [Scaling mode](#scaling-mode)
  * [Rotating mode](#rotating-mode)

## General info

The project is 3D engine containing basic functionalities such as loading 3D models in .obj format, loading textures for models, rotating, moving and scaling models. It's also possible to move and rotate the camera.

## Technologies

* [.NET 8.0](https://dotnet.microsoft.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
* [GtkSharp](https://github.com/GtkSharp/GtkSharp)
* [Math.NET](https://www.mathdotnet.com/)
* [SixLabors.ImageSharp](https://sixlabors.com/products/imagesharp/)

## Setup

To run this project:

1. Install [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. Install GTK3 (on macOS: `brew install gtk+3`)
3. Clone the repository
4. Run `dotnet run` in the project directory

## Controls

### General

| Key                           | Function                                   |
| ----------------------------- | ------------------------------------------ |
| W                             | Move the camera forward                    |
| S                             | Move the camera backward                   |
| A                             | Move the camera to the left                |
| D                             | Move the camera to the right               |
| Q                             | Move the camera up                         |
| Z                             | Move the camera down                       |
| LMB + Mouse move              | Rotate the camera in the x-axis and y-axis |
| Left Shift + LMB + Mouse move | Rotate the camera in the z-axis            |
| Mouse Scroll                  | Zoom                                       |
| 1                             | Change mode to moving                      |
| 2                             | Change mode to scaling                     |
| 3                             | Change mode to rotating                    |

### Moving mode

| Key                                    | Function                          |
| -------------------------------------- | --------------------------------- |
| RMB + Horizontal mouse move            | Move the object to the left/right |
| RMB + Vertical mouse move              | Move the object up/down           |
| Left Shift + RMB + Vertical mouse move | Move the object to/from yourself  |

### Scaling mode

| Key                                    | Function                                     |
| -------------------------------------- | -------------------------------------------- |
| RMB + Horizontal mouse move            | Scale the object horizontally                |
| RMB + Vertical mouse move              | Scale the object vertically                  |
| Left Shift + RMB + Vertical mouse move | Scale the object horizontally and vertically |

### Rotating mode

| Key                                    | Function                        |
| -------------------------------------- | ------------------------------- |
| RMB + Horizontal mouse move            | Rotate the object horizontally  |
| RMB + Vertical mouse move              | Rotate the object vertically    |
| Left Shift + RMB + Vertical mouse move | Rotate the object in the z-axis |

## TODO

* Models parser optimization
* Repairing camera rotation
* Multiple light sources
* FPP like camera

## Bugs

* Some models don't load
