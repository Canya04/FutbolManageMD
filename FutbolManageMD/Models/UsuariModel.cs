using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolManageMD.Models
{
    public class UsuariModel
    {
        public int Id { get; set; }
        public string Nom_Jugador { get; set; }
        public string Cognoms_Jugador { get; set; }
        public string Correu_Jugador { get; set; }
        public string Contrasenya_Jugador { get; set; }
        public string Sexe_Jugador { get; set; }
        public string Id_equip { get; set; }
    }
}
