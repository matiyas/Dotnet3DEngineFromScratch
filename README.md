# Dotnet3DEngineFromScratch

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![GTK](https://img.shields.io/badge/GTK-3-7FE719?logo=gtk)](https://www.gtk.org/)
[![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20macOS%20%7C%20Linux-lightgrey)]()

## Table of contents

* [General info](#general-info)
* [Technologies](#technologies)
* [Installation](#installation)
  * [macOS](#macos)
  * [Linux](#linux-ubuntudebian)
  * [Windows](#windows)
* [Controls](#controls)
  * [General](#general)
  * [Moving mode](#moving-mode)
  * [Scaling mode](#scaling-mode)
  * [Rotating mode](#rotating-mode)
* [Troubleshooting](#troubleshooting)

## General info

The project is 3D engine containing basic functionalities such as loading 3D models in .obj format, loading textures for models, rotating, moving and scaling models. It's also possible to move and rotate the camera.

## Technologies

* [.NET 8.0](https://dotnet.microsoft.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
* [GtkSharp](https://github.com/GtkSharp/GtkSharp)
* [Math.NET](https://www.mathdotnet.com/)
* [SixLabors.ImageSharp](https://sixlabors.com/products/imagesharp/)

## Installation

### Prerequisites

Install [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) for your platform.

**Note:** If you install .NET using the install script, you'll need to add it to your PATH:
```bash
export PATH="$PATH:$HOME/.dotnet"
```

To make this permanent, add the above line to your shell profile (`~/.bashrc`, `~/.zshrc`, or `~/.profile`).

### macOS

```bash
# Install GTK3 using Homebrew
brew install gtk+3

# Clone and run
git clone https://github.com/matiyas/Dotnet3DEngineFromScratch.git
cd Dotnet3DEngineFromScratch/Dotnet3DEngineFromScratch
dotnet run
```

### Linux (Ubuntu/Debian)

```bash
# Install GTK3
sudo apt-get update
sudo apt-get install libgtk-3-dev

# Clone and run
git clone https://github.com/matiyas/Dotnet3DEngineFromScratch.git
cd Dotnet3DEngineFromScratch/Dotnet3DEngineFromScratch
dotnet run
```

### Linux (Fedora)

```bash
# Install GTK3
sudo dnf install gtk3-devel

# Clone and run
git clone https://github.com/matiyas/Dotnet3DEngineFromScratch.git
cd Dotnet3DEngineFromScratch/Dotnet3DEngineFromScratch
dotnet run
```

### Linux (Arch)

```bash
# Install GTK3
sudo pacman -S gtk3

# Clone and run
git clone https://github.com/matiyas/Dotnet3DEngineFromScratch.git
cd Dotnet3DEngineFromScratch/Dotnet3DEngineFromScratch
dotnet run
```

### Windows

```powershell
# Install .NET 8.0 SDK
winget install Microsoft.DotNet.SDK.8

# Install MSYS2
winget install MSYS2.MSYS2

# Install GTK3 (run after MSYS2 installation)
C:\msys64\usr\bin\pacman.exe -S --noconfirm mingw-w64-x86_64-gtk3

# Add GTK3 to PATH (current session)
$env:Path += ";C:\msys64\mingw64\bin"

# Add GTK3 to PATH (permanently)
[Environment]::SetEnvironmentVariable("Path", $env:Path + ";C:\msys64\mingw64\bin", "User")

# Clone and run
git clone https://github.com/matiyas/Dotnet3DEngineFromScratch.git
cd Dotnet3DEngineFromScratch/Dotnet3DEngineFromScratch
dotnet run
```

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
| Shift + LMB + Mouse move | Rotate the camera in the z-axis            |
| Mouse Scroll                  | Zoom                                       |
| 1                             | Change mode to moving                      |
| 2                             | Change mode to scaling                     |
| 3                             | Change mode to rotating                    |

### Moving mode

| Key                                    | Function                          |
| -------------------------------------- | --------------------------------- |
| RMB + Horizontal mouse move            | Move the object to the left/right |
| RMB + Vertical mouse move              | Move the object up/down           |
| Shift + RMB + Vertical mouse move | Move the object to/from yourself  |

### Scaling mode

| Key                                    | Function                                     |
| -------------------------------------- | -------------------------------------------- |
| RMB + Horizontal mouse move            | Scale the object horizontally                |
| RMB + Vertical mouse move              | Scale the object vertically                  |
| Shift + RMB + Vertical mouse move | Scale the object horizontally and vertically |

### Rotating mode

| Key                                    | Function                        |
| -------------------------------------- | ------------------------------- |
| RMB + Horizontal mouse move            | Rotate the object horizontally  |
| RMB + Vertical mouse move              | Rotate the object vertically    |
| Shift + RMB + Vertical mouse move | Rotate the object in the z-axis |

## Troubleshooting

### Wayland

The application forces the X11 backend on Linux because GtkSharp does not render correctly under Wayland. This means XWayland must be available. Most Wayland compositors (GNOME, KDE Plasma, Sway) ship XWayland by default, but if the app fails to open a display, install it:

```bash
# Ubuntu/Debian
sudo apt-get install xwayland

# Fedora
sudo dnf install xorg-x11-server-Xwayland

# Arch
sudo pacman -S xorg-xwayland
```

### GTK Module Warning on Linux

You may see a warning message like this when running the application:
```
Gtk-Message: Failed to load module "appmenu-gtk-module"
```

This is a harmless warning about an optional GTK module and does not affect the application's functionality. You can safely ignore it.

## TODO

* Models parser optimization
* Repairing camera rotation
* Multiple light sources
* FPP like camera

## Bugs

* Some models don't load
