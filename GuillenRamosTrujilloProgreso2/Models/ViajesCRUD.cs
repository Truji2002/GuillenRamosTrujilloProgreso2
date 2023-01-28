using SQLite;
using System.ComponentModel.DataAnnotations;

namespace GuillenRamosTrujilloProgreso2.Models
{
    [Table("viajes12")]
    public class ViajesCRUD
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el pais")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Ingrese la ciudad")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del lugar")]
        public string NombreLugar { get; set; }

        [Required(ErrorMessage = "Ingrese la reseña del lugar")]
        public string Resenia { get; set; }

        [Required(ErrorMessage = "Ingrese información adicional del lugar")]
        public string Info { get; set; }

        [Required(ErrorMessage = "Ingrese la fecha de su visista")]
        public DateTime Date { get; set; }

        public bool Servicio { get; set; }

        public string byteBase64 { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }


    }
}
