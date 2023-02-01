namespace GuillenRamosTrujilloProgreso2;

public partial class BeginPage : ContentPage
{
	public BeginPage()
	{
		InitializeComponent();
	}

    public async void CerrarSesión(object sender, EventArgs e)
    {
        await NavigationService.NavigateAsync("PageName");
    }
    
}