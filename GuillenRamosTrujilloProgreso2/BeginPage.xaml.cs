namespace GuillenRamosTrujilloProgreso2;

public partial class BeginPage : ContentPage
{
	public BeginPage()
	{
		InitializeComponent();
	}

    public async void CerrarSesi�n(object sender, EventArgs e)
    {
        await BeginPage.Current.GoToAsync(new MainPage());
    }
}