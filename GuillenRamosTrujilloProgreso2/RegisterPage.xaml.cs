using GuillenRamosTrujilloProgreso2.ViewModels;

namespace GuillenRamosTrujilloProgreso2;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
		BindingContext = new RegisterViewModel(Navigation);
	}
}