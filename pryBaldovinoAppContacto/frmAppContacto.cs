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

  
        string vContacto = "";
        string vTelefono = "";
        int vContador = 0;

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            vContador++;
            vContacto = txtContacto.Text;
            vTelefono = txtTelefono.Text;

            string vResultado = vContador + "---" + vContacto + "---" vTelefono;
            lstDatos.Items.Add(vResultado);

            string vContacto = "";
            string vTelefono = "";
            txtContacto.Focus();
        }
    }
}

