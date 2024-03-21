using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FutbolManageMD.Models
{
    public interface IUsuariRepository
    {
        bool AuthenticateUsuari(NetworkCredential credential);
        void Add(UsuariModel usuariModel);
        void Edit(UsuariModel usuariModel);
        void Remove(int id);
        UsuariModel GetById(int id);
        UsuariModel GetByUsuari(string usuari);
        IEnumerable<UsuariModel> GetByAll();  
    }
}
