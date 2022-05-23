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
using System.Data;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked == false)
            {

            }
        }
    }
}
