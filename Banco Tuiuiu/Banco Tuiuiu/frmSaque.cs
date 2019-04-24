using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Tuiuiu
{
    public partial class frmSaque : Form
    {
        public string Saldo { get => txtSaldoSaque.Text; set => txtSaldoSaque.Text = value; }

        public frmSaque()
        {
            InitializeComponent();
        }

        private void btnCancelarSaque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmaSaque_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Saldo = decimal.Parse(txtSaldoSaque.Text) - decimal.Parse(txtValorSaque.Text);
        }
    }
}
