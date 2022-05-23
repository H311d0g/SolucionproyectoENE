using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class UserConsults:DB
    {
        public bool Login(string email, string clave)
        {
            using (var conn= GetConnection())
            {
                conn.Open();
                using (var scmd = new SqlCommand())
                {
                    scmd.Connection=conn;
                    scmd.CommandText = "SELECT email FROM usuario WHERE email= @vemail AND clave= @vclave";
                    scmd.Parameters.AddWithValue("@vemail", email);
                    scmd.Parameters.AddWithValue("@vclave", clave);
                    scmd.CommandType = CommandType.Text;
                    SqlDataReader read = scmd.ExecuteReader();
                    if (read.Read()== true)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
        }
    }
}
