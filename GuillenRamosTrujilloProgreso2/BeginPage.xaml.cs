namespace GuillenRamosTrujilloProgreso2;

public partial class BeginPage : ContentPage
{
	public BeginPage()
	{
		InitializeComponent();
	}

    private async void Cerrar(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}