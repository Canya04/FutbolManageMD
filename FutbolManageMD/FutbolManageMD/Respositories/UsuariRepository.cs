using FutbolManageMD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FutbolManageMD.Respositories
{
    public class UsuariRepository : RepositoryBase, IUsuariRepository
    {
        public void Add(UsuariModel usuariModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUsuari(NetworkCredential credential)
        {
            bool usuariValid;
            using (var connexio = GetConnexio())
            using (var command = new SqlCommand())
            {
                connexio.Open();
                command.Connection = connexio;
                command.CommandText = "select * from [Usuari] where Usuari_Usuari = @usuari and [Contrassenya_Usuari] = @contrassenya";
                command.Parameters.Add("@usuari", SqlDbType.NVarChar).Value=credential.UserName;
                command.Parameters.Add("@contrassenya", SqlDbType.NVarChar).Value=credential.Password;
                usuariValid = command.ExecuteScalar() == null? false : true;
            }
            return usuariValid;
        }

        public void Edit(UsuariModel usuariModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuariModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        public UsuariModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UsuariModel GetByUsuari(string usuari)
        {
            UsuariModel user = null;
            using (var connexio = GetConnexio())
            using (var command = new SqlCommand())
            {
                connexio.Open();
                command.Connection = connexio;
                command.CommandText = "select * from [Usuari] where Usuari_Usuari = @usuari";
                command.Parameters.Add("@usuari", SqlDbType.NVarChar).Value = usuari;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UsuariModel()
                        {
                            Id = (int)reader[0],
                            Usuari = reader[1].ToString(),
                            Contrassenya = string.Empty,
                            Nom = reader[3].ToString(),
                            Cognom = reader[4].ToString(),
                            Correu = reader[5].ToString(),
                        };
                    }
                }
            }
            return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
