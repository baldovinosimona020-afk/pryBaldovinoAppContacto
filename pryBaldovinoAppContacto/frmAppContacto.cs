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

        string vContacto
        string vTelefono

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            vContador++;
            vContacto = txtContacto.Text;
            vTelefono = txtTelefono.Text;

        }
    }
}
