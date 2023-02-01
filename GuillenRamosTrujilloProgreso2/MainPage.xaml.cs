using GuillenRamosTrujilloProgreso2.ViewModels;

namespace GuillenRamosTrujilloProgreso2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(Navigation);
		Routing.RegisterRoute(nameof(BeginPage), typeof(BeginPage));
	}
}

