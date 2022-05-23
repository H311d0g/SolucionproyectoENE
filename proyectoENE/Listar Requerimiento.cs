using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Data.SqlClient;
using BusinessLayer;

namespace proyectoENE
{
    public partial class Listar_Requerimiento : Form
    {
        public Listar_Requerimiento()
        {
            InitializeComponent();
        }

        private void Listar_Requerimiento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet10.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter5.Fill(this.pRUEBAENEDataSet10.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet9.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter4.Fill(this.pRUEBAENEDataSet9.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet7.requerimientos_form' table. You can move, or remove it, as needed.
            this.requerimientos_formTableAdapter1.Fill(this.pRUEBAENEDataSet7.requerimientos_form);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet6.requerimientos_form' table. You can move, or remove it, as needed.
            this.requerimientos_formTableAdapter.Fill(this.pRUEBAENEDataSet6.requerimientos_form);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet5.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter3.Fill(this.pRUEBAENEDataSet5.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet4.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter2.Fill(this.pRUEBAENEDataSet4.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet3.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter1.Fill(this.pRUEBAENEDataSet3.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter.Fill(this.pRUEBAENEDataSet.requerimiento);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s"))
            {
                string query = "SELECT tipo_req, responsable_req, descripcion, prioridad FROM requerimiento WHERE estado=0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//boton buscar
            try
            {
                string tipo_req = comboBox1.Text;
                string prioridad = comboBox2.Text;
                using (SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; user id= sa; password= h4ckth1s"))
                {
                    conn.Open();
                    string query = string.Format("SELECT tipo_req, prioridad, descripcion, dias_plazo FROM requerimiento WHERE tipo_req= @tipo_req AND prioridad=@prioridad");
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@tipo_req", tipo_req);
                    sda.SelectCommand.Parameters.AddWithValue("prioridad", prioridad);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//boton eliminar
            DataGridViewRow row = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(row.Cells["id"].Value);
            datagridModel dgm = new datagridModel();
            var er = dgm.Erease(id);
            if (er == true)
            {
                MessageBox.Show("Registro eliminado");
                Listar_Requerimiento lr = new Listar_Requerimiento();
                lr.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {//boton volver
            Registro_Requerimiento rg = new Registro_Requerimiento();
            rg.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Marcar resuelto
            DataGridViewRow dr = dataGridView1.CurrentRow;
            int up = Convert.ToInt32(dr.Cells["estado"].Value);
            datagridModel dgm = new datagridModel();
            var udv = dgm.UpdateGrid(up);
            if (udv == true)
            {
                MessageBox.Show("Marcado como resuelto");
                Listar_Requerimiento lr = new Listar_Requerimiento();
                lr.Show();
                this.Close();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s"))
            {
                string query = "SELECT tipo_req, responsable_req, descripcion, prioridad FROM requerimiento WHERE estado=1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
