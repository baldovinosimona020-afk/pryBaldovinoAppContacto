using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoAppContacto
{
    public partial class frmAppContacto : Form
    {
        public frmAppContacto()
        {
            InitializeComponent();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        string vContacto = "";
        string vTelefono = "";
        int vContador = 0;
        int indice = 0;

        string[] vecContacto = new string[8];
        string[] vecTelefono = new string[8];


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
                btnGrabar.Enabled = true;

            vContador++;
            vContacto = txtContacto.Text;   
            vTelefono = txtTelefono.Text;

            string vResultado = vContacto + " -- " + vTelefono;
            
            lstDatos.Items.Add(vResultado);

            vecContacto[indice] = vContacto;
            vecTelefono[indice] = vTelefono;
            indice++;


            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtContacto.Focus();
        }
    }
}
