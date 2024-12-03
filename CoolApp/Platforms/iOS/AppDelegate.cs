using Foundation;
using UIKit;
using UIKit;

namespace CoolApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	public override bool FinishedLaunching(UIApplication app, NSDictionary options) { SQLitePCL.Batteries_V2.Init(); return base.FinishedLaunching(app, options); }
}
