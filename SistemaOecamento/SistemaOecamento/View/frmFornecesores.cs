using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOecamento.View
{
    public partial class frmFornecesores : Form
    {
        public frmFornecesores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HbilitarCampos();
        }

        private void HbilitarCampos()
        {
            txtNome.Enabled = true;
            mtxtCnpj.Enabled = true;
            mtxtTelefone.Enabled = true;
            txtEndereco.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            mtxtCnpj.Enabled = false;
            mtxtTelefone.Enabled = false;
            txtEndereco.Enabled = false;
        }
    }
}
