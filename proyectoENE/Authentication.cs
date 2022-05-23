using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace proyectoENE
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "email" && textBox1.TextLength > 2)
            {
                if (textBox2.Text != "clave")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.UserLogin(textBox1.Text, textBox2.Text);
                    if (validLogin == true)
                    {
                        Registro_Requerimiento form = new Registro_Requerimiento();
                        form.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("usuario o clave incorrecta");
                    }
                }
            }
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }
    }
}
