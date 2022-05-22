using System;
using SistemaOecamento.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOecamento
{
    public partial class frmSistemadeOrcamento : Form
    {
        public frmSistemadeOrcamento()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecesores frm = new frmFornecesores();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.ShowDialog();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidades frm = new frmUnidades();
            frm.ShowDialog();
        }

        private void novoOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrcamento frm = new frmOrcamento();
            frm.ShowDialog();
        }
    }
}
