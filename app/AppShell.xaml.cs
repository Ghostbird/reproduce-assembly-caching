using lib;

namespace app;

public partial class AppShell : Shell
{
  public AppShell()
  {
    InitializeComponent();
    new TryToFindMe();
  }
}
