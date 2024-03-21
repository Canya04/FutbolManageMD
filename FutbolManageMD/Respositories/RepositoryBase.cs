using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FutbolManageMD.Respositories
{
    public class RepositoryBase
    {
        private readonly string connexioString;
        public RepositoryBase()
        {
            connexioString = "Server=(local); Database=FutbolManageMD; Integrated Security=True";
        }
        protected SqlConnection GetConnexio() 
        {
            return new SqlConnection(connexioString);
        }
    }
}
