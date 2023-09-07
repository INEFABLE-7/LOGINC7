using Microsoft.VisualBasic;
using System;


namespace LOGINC7_JEAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click_1(object sender, EventArgs e)
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

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }
    }
}