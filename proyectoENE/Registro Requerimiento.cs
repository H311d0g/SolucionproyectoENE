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
    public partial class Registro_Requerimiento : Form
    {
        public Registro_Requerimiento()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listar_Requerimiento form = new Listar_Requerimiento();
            form.ShowDialog();
            this.Hide();
        }

        private void Registro_Requerimiento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet8.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter2.Fill(this.pRUEBAENEDataSet8.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet1.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter1.Fill(this.pRUEBAENEDataSet1.usuario);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet7.requerimientos_form' table. You can move, or remove it, as needed.
            this.requerimientos_formTableAdapter1.Fill(this.pRUEBAENEDataSet7.requerimientos_form);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet6.requerimientos_form' table. You can move, or remove it, as needed.
            this.requerimientos_formTableAdapter.Fill(this.pRUEBAENEDataSet6.requerimientos_form);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet3.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter1.Fill(this.pRUEBAENEDataSet3.requerimiento);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet2.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.pRUEBAENEDataSet2.usuario);
            // TODO: This line of code loads data into the 'pRUEBAENEDataSet.requerimiento' table. You can move, or remove it, as needed.
            this.requerimientoTableAdapter.Fill(this.pRUEBAENEDataSet.requerimiento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s");
            conn.Open();
            string req_sort = comboBox1.Text;
            string given_to = comboBox2.Text;
            string describe = textBox1.Text;
            string priority = comboBox3.Text;
            if (comboBox3.SelectedIndex== 0)
            {
                string Sql = "INSERT INTO requerimiento(tipo_req, responsable_req, descripcion, prioridad, dias_plazo) VALUES ('" + req_sort + "', '" + given_to + "', '" + describe + "', '" + priority + "', "+3+")";
                SqlCommand fcmd = new SqlCommand(Sql, conn);
                fcmd.ExecuteNonQuery();
                MessageBox.Show("El requerimiento fue ingresado, el plazo es 3 días");
            }
            else
            {
                if (comboBox3.SelectedIndex == 1)
                {
                    string Sql = "INSERT INTO requerimiento(tipo_req, responsable_req, descripcion, prioridad, dias_plazo) VALUES ('" + req_sort + "', '" + given_to + "', '" + describe + "', '" + priority + "', " + 4 + ")";
                    SqlCommand fcmd = new SqlCommand(Sql, conn);
                    fcmd.ExecuteNonQuery();
                    MessageBox.Show("El requerimiento fue ingresado, el plazo es 4 días");
                }
                else
                {
                    if (comboBox3.SelectedIndex == 2)
                    {
                        string Sql = "INSERT INTO requerimiento(tipo_req, responsable_req, descripcion, prioridad, dias_plazo) VALUES ('" + req_sort + "', '" + given_to + "', '" + describe + "', '" + priority + "', " + 5 + ")";
                        SqlCommand fcmd = new SqlCommand(Sql, conn);
                        fcmd.ExecuteNonQuery();
                        MessageBox.Show("El requerimiento fue ingresado, el plazo es 5 días");
                    }
                }               
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
