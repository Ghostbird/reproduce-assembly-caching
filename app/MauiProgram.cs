namespace app;

public static class MauiProgram
{
  public static MauiApp CreateMauiApp()
  => MauiApp.CreateBuilder().UseMauiApp<App>().Build();
}
