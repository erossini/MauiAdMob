using Plugin.MauiMTAdmob;

namespace MauiAdMob;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        CrossMauiMTAdmob.Current.UserPersonalizedAds = true;
        CrossMauiMTAdmob.Current.ComplyWithFamilyPolicies = true;
        CrossMauiMTAdmob.Current.UseRestrictedDataProcessing = true;
        CrossMauiMTAdmob.Current.AdsId = DeviceInfo.Platform == DevicePlatform.Android ? "ca-app-pub-4381168884554284/2250461656" : "ca-app-pub-4381168884554284/5843056458";
        CrossMauiMTAdmob.Current.TestDevices = new List<string>() { };

        MainPage = new AppShell();
	}
}