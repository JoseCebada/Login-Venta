using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToLower() == "juancho")
            {
                if (txtContra.Text.ToLower() == "123tamarindo")
                {
                    this.Hide();
                    Form2 venta = new Form2();
                    venta.Show();
                }
                else
                    MessageBox.Show("Contraseña incorrecta");
            }
            else
                MessageBox.Show("Nombre de usuario incorrecto.");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
