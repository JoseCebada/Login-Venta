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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if (checkC.Checked == true)
            {
                conteo++;
            }
            if (checkBasic.Checked == true)
            {
                conteo++;
            }
            if(radioTarjeta.Checked == true)
            {
                seleccion = "Tarjeta de crédito.";
            }
            else if(radioPaypal.Checked == true)
            {
                seleccion = "Paypal.";
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Visible = true;
            this.Hide();
        }

    }
}
