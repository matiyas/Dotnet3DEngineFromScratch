using System;
using System.Runtime.InteropServices;
using Gtk;

namespace Dotnet3DEngineFromScratch;

class Program
{
  [DllImport("libgdk-3.so.0")]
  private static extern void gdk_set_allowed_backends(string backends);

  [STAThread]
  public static void Main()
  {
    // GtkSharp does not display windows on the Wayland backend;
    // force X11 (via XWayland) so the window is visible on Wayland sessions.
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    {
      gdk_set_allowed_backends("x11");
    }

    Application.Init();

    var app = new Application("org.Dotnet3DEngineFromScratch.Dotnet3DEngineFromScratch", GLib.ApplicationFlags.None);
    app.Register(GLib.Cancellable.Current);

    var win = new MainWindow();
    app.AddWindow(win);

    win.ShowAll();
    Application.Run();
  }
}
