using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using CoolApp.Data;

namespace CoolApp;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder.Services.AddSingleton<IDiseasesRepository, DiseasesRepository>();
		builder
			.UseMauiApp<App>().ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.UseMauiCommunityToolkit();
			
		// builder.Services.AddSingleton<DiseasesRepository>();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}