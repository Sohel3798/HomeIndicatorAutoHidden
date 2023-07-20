using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace HomeIndicatorAutoHidden;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
        On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden());
    }
}


