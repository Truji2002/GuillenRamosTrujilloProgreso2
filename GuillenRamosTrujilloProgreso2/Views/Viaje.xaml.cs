using static System.Net.Mime.MediaTypeNames;

namespace GuillenRamosTrujilloProgreso2.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]

public partial class Viaje : ContentPage
{

    //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "viajes.txt");

    public string ItemId
    {
        set { LoadViaje(value); }
    }

    public Viaje()
	{
		InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.viajes.txt";

        LoadViaje(Path.Combine(appDataPath, randomFileName));
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {

        //string resenia = NombrePais.Text + "\n" + NombreCiudad.Text + "\n" + NombreLugar.Text + "\n" + TextEditor.Text;
        //File.WriteAllText(_fileName, resenia);

        if (BindingContext is Models.Viaje viaje)
            File.WriteAllText(viaje.Filename, NombrePais.Text + "\n" + NombreCiudad.Text + "\n" + NombreLugar.Text + "\n" + TextEditor.Text);

        await Shell.Current.GoToAsync("..");

    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        //if (File.Exists(_fileName))
        //    File.Delete(_fileName);

        //NombrePais.Text = string.Empty;
        //NombreCiudad.Text = string.Empty;
        //NombreLugar.Text = string.Empty;

        //TextEditor.Text = string.Empty;

        if (BindingContext is Models.Viaje viaje)
        {
            // Delete the file.
            if (File.Exists(viaje.Filename))
                File.Delete(viaje.Filename);
        }

        await Shell.Current.GoToAsync("..");
    }

    private void LoadViaje(string fileName)
    {
        Models.Viaje viajeModel = new Models.Viaje();
        viajeModel.Filename = fileName;

        if (File.Exists(fileName))

        {
            
            viajeModel.Date = File.GetCreationTime(fileName);
            viajeModel.Info = File.ReadAllText(fileName);
        }

        BindingContext = viajeModel;
    }
}