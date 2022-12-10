namespace GuillenRamosTrujilloProgreso2;

public partial class Viaje : ContentPage
{

    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "viajes.txt");

    public Viaje()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, TextEditor.Text);

    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }
}