using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuillenRamosTrujilloProgreso2.Models
{
    class AllViajes
    {

        public ObservableCollection<Viaje> Viajes { get; set; } = new ObservableCollection<Viaje>();

        public AllViajes() =>
            LoadViajes();

        public void LoadViajes()
        {
            Viajes.Clear();

            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<Viaje> viajes = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.viajes.txt")

                                        // Each file name is used to create a new Note
                                        .Select(filename => new Viaje()
                                        {
                                            Filename = filename,
                                            Info = File.ReadAllText(filename),
                                            Date = File.GetCreationTime(filename)
                                        })

                                        // With the final collection of notes, order them by date
                                        .OrderBy(viaje => viaje.Date);

            // Add each note into the ObservableCollection
            foreach (Viaje viaje in viajes)
                Viajes.Add(viaje);
        }
    }
}
