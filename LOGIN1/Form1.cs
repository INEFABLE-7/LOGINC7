using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string password;
            usuario = txtusuario.Text;
            password = txtcontraseña.Text;

            if (usuario == "JEAN POL" && password == "123")
            {
                Form2 miFormulario = new Form2();
                miFormulario.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos - Intente de nuevo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtcontraseña.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
                Form4 miFormulario = new Form4();
                miFormulario.Show();
            
        }
    }
}
