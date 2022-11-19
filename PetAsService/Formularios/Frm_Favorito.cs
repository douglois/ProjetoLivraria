using PetAsService.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PetAsService
{
    public partial class Frm_Favorito : Form
    {
        List<List<string>> _lista = new List<List<string>>();

        public string racaSelect { get; set; }
        public Frm_Favorito(List<List<string>> listaBusca)
        {
            _lista = listaBusca;
            InitializeComponent();
            lblTextoFavorito.Font = new Font(lblTextoFavorito.Font, FontStyle.Bold);
            lblTextoFavorito.Text = "Meus Favoritos";
            lblDescFavoritos.Text = "Aqui você encontra sua lista de raças favoritas.";

            PrencherLista();
        }

        private void PrencherLista()
        {
            lstFavorito.Items.Clear();

            for (int i = 0; i<= _lista.Count -1;i++)
            {
                lstFavorito.Items.Add(_lista[i][0]);
            }
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exibirFavoritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstFavorito.SelectedIndex != -1)
            {
                DialogResult = DialogResult.OK;
                racaSelect = _lista[lstFavorito.SelectedIndex][0];
            }else
            {
                MessageBox.Show("Selecione uma raça para exibir os detalhe"
                              , "Pet as Service"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Warning);
            }
        }

        private void lstFavorito_DoubleClick(object sender, EventArgs e)
        {
            if(lstFavorito.SelectedIndex != -1)
            {
                DialogResult = DialogResult.OK;
                racaSelect = _lista[lstFavorito.SelectedIndex][0];
            }else
            {
                MessageBox.Show("Selecione uma raça para exibir os detalhe"
                              , "Pet as Service"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Warning);
            }
        }

        private void lstFavorito_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstFavorito.SelectedIndex != -1)
            {
                picFavorito.ImageLocation = _lista[lstFavorito.SelectedIndex][1];
            }
        }

        private void lstFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFavorito.SelectedIndex != -1)
            {
                picFavorito.ImageLocation = _lista[lstFavorito.SelectedIndex][1];
            }
        }

        private void btnExcluirFavorito_Click(object sender, EventArgs e)
        {
            Fichario fichario = new Fichario("C:\\Users\\dlois\\Desktop\\Estudos\\C#_Forms\\PetAsService\\Fichario");
            var racaParaexcluir = _lista[lstFavorito.SelectedIndex];

            DialogResult result = MessageBox.Show("Deseja realizar a exclusão da raça" + _lista[lstFavorito.SelectedIndex][0] + "?"
                              , "Pet as Service"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                lstFavorito.Items.Remove(lstFavorito.SelectedIndex);
                _lista.Remove(racaParaexcluir);
                fichario.ExcluirFavorito(_lista[lstFavorito.SelectedIndex][0]);
                lstFavorito.Refresh();
            }
        }
         
    }
}
