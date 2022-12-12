namespace GuillenRamosTrujilloProgreso2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.Viaje), typeof(Views.Viaje));
    }
}
