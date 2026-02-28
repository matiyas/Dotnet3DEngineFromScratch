using System;
using Gtk;

namespace Dotnet3DEngineFromScratch;

class Program
{
  [STAThread]
  public static void Main()
  {
    Application.Init();

    var app = new Application("org.Dotnet3DEngineFromScratch.Dotnet3DEngineFromScratch", GLib.ApplicationFlags.None);
    app.Register(GLib.Cancellable.Current);

    var win = new MainWindow();
    app.AddWindow(win);

    win.Show();
    Application.Run();
  }
}
