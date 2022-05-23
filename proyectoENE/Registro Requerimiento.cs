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
            if (comboBox3.SelectedIndex == 0)
            {
                MessageBox.Show("El requerimiento fue ingresado, el plazo para resolverlo es de 3 días");
                if (comboBox3.SelectedIndex == 1)
                {
                    MessageBox.Show("El requerimiento fue ingresado, el plazo para resolverlo es de 4 días");
                    if (comboBox3.SelectedIndex == 2)
                    {
                        MessageBox.Show("El requerimiento fue ingresado, el plazo para resolverlo es de 5 días");
                    }
                }
            }
            comboBox1.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; Initial Catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO requerimiento (tipo_req, responsable_req, descripcion, prioridad, dias_plazo VALUES ())");
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
