using GuillenRamosTrujilloProgreso2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuillenRamosTrujilloProgreso2.Models
{
    class Viaje

    {
        public string Filename { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string NombreLugar { get; set; }

        public string Resenia { get; set; }

        public string Info { get; set; }

        public DateTime Date { get; set; }

        public LoginViewModel UserName { get; set; }

        public void setUserName(string username)
        {
            string aux = UserName.ToString();
            aux =username;  
        }
    }
}
