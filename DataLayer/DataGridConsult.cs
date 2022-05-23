using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer;

namespace DataLayer
{
    public class DataGridConsult:DB
    {
        public bool DeleteGrid(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var dcmd = new SqlCommand())
                {
                    dcmd.Connection=conn;
                    dcmd.CommandText = "DELETE FROM requerimiento WHERE id=@id";
                    dcmd.Parameters.AddWithValue("@id", id);
                    dcmd.CommandType= System.Data.CommandType.Text;
                    try
                    {
                        dcmd.ExecuteNonQuery();
                        return true;
                    }
                    catch { return false; }
                }
            }
        }

        public bool UpdateGrid(int estado)
        {
            using(var conn = GetConnection())
            {
                conn.Open();
                using(var ucmd = new SqlCommand())
                {
                    ucmd.Connection=conn;
                    ucmd.CommandText = "UPDATE requerimiento SET estado= 1 WHERE estado=@estado";
                    ucmd.Parameters.AddWithValue("@estado", estado);
                    ucmd.CommandType= System.Data.CommandType.Text;
                    try
                    {
                        ucmd.ExecuteNonQuery();
                        return true;
                    }
                    catch { return false; }
                }
            }
        }
    }
}
