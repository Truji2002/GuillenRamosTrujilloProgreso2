using SQLite;

namespace GuillenRamosTrujilloProgreso2.Models
{
    [Table("viajes12")]
    public class ViajesCRUD
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string NombreLugar { get; set; }

        public string Resenia { get; set; }

        public string Info { get; set; }

        public DateTime Date { get; set; }

        public bool Servicio { get; set; }
    }
}
