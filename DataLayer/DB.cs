using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    //Crear string de conexión
    public abstract class DB
    {
        private readonly string connectionString;
        public DB()
        {
            connectionString = @"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        /*SqlConnection cnn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s");
        public SqlConnection OpenFrom()
        {
            cnn.Open();
            return cnn;
        }

        public SqlConnection CloseFrom()
        {
            cnn.Close();
            return cnn;
        }*/
    }

    
}
