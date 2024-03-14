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
                command.CommandText = "select * from [Jugador] where Nom_Jugador = @jugador and [Contrasenya_Jugador] = @contrasenya";
                command.Parameters.Add("@jugador", SqlDbType.NVarChar).Value=credential.UserName;
                command.Parameters.Add("@contrasenya", SqlDbType.NVarChar).Value=credential.Password;
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
                command.CommandText = "select * from [Jugador] where Nom_Jugador = @jugador";
                command.Parameters.Add("@jugador", SqlDbType.NVarChar).Value = usuari;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UsuariModel()
                        {
                            Id = (int)reader[0],
                            Nom_Jugador = reader[1].ToString(),
                            Cognoms_Jugador = reader[2].ToString(),
                            Correu_Jugador = reader[3].ToString(),
                            Contrasenya_Jugador = string.Empty,
                            Sexe_Jugador = reader[5].ToString(),
                            Id_equip = reader[6].ToString(),    
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
