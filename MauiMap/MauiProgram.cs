using CommunityToolkit.Maui.Maps;

namespace MauiMap;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkitMaps("Get Your Key from https://www.bingmapsportal.com/")
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<MapViewModel>();

		builder.Services.AddSingleton<BingMap>();

		builder.Services.AddSingleton<EmbeddedMap>();

		return builder.Build();
	}
}
