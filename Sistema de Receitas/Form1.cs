using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Receitas
{
    public partial class Form1 : Form
    {
        RadioButton rbnBolos = null;
        ListViewItem listitem;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbnBolos_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnBolos = rbn;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            listitem = lvReceitasCadastradas.Items.Add(txtNome.Text);
            listitem.SubItems.Add(txtIngredientes.Text);
            listitem.SubItems.Add(rbnBolos.Text);
            listitem.SubItems.Add(txtModoPreparo.Text);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            lvReceitasCadastradas.Items.Remove(lvReceitasCadastradas.SelectedItems[0]);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lvReceitasCadastradas.Items.Clear();
        }
    }
}
