using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    /*public class FormRegister:DB
    {   
        public bool Register(string req_sort, string given_to, string describe, string priority)
        {
            using (var conn = GetConnection())
                conn.Open();
            SqlCommand fcmd = new SqlCommand();
            fcmd.CommandType = System.Data.CommandType.Text;
            fcmd.CommandText = "INSERT INTO requerimiento(tipo_req, responsable_req, descripcion, prioridad)VALUES('"+req_sort+"', '"+given_to+"', '"+describe+"', '"+priority+"')";
            fcmd.Parameters.AddWithValue("@req_sort", req_sort);
            fcmd.Parameters.AddWithValue("@given_to", given_to);
            fcmd.Parameters.AddWithValue("@describe", describe);
            fcmd.Parameters.AddWithValue("@priority", priority);
            try
            {
                fcmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }*/
}