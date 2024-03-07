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
        public string Usuari { get; set; }
        public string Contrassenya { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public string Correu { get; set; }
        public string Genere { get; set; }
    }
}
