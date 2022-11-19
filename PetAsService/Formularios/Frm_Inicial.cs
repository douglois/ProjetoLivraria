using PetAsService.Classes;
using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace PetAsService
{
    public partial class Frm_Inicial : Form
    {
        public Frm_Inicial()
        {
            InitializeComponent();
        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscaRaca buscaRaca = new Frm_BuscaRaca();
            buscaRaca.ShowDialog();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fichario fichario = new Fichario("C:\\Users\\dlois\\Desktop\\Estudos\\C#_Forms\\PetAsService\\Fichario");
            Frm_BuscaRaca buscaRaca = new Frm_BuscaRaca();

            if (fichario.status)
            {
                List<string> list = new List<string>();
                list = fichario.BuscarFavoritos();

                if (fichario.status)
                {
                    List<List<string>> listaBusca = new List<List<string>>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        DadosGato dadosGato = JsonConvert.DeserializeObject<DadosGato>(list[i]);
                        listaBusca.Add(new List<string> { dadosGato.name,dadosGato.image.url });
                    }
                     Frm_Favorito frm_Favorito = new Frm_Favorito(listaBusca);
                     frm_Favorito.ShowDialog();

                    if(frm_Favorito.DialogResult == DialogResult.OK)
                    {
                        var racaSelect = frm_Favorito.racaSelect;
                        string racaJson = fichario.BuscarGato(racaSelect);
                        DadosGato dadosGato = new DadosGato();
                        dadosGato = JsonConvert.DeserializeObject<DadosGato>(racaJson);
                        buscaRaca.EscreveFormulario(dadosGato);
                        buscaRaca.ShowDialog();
                    }
                }
            }
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}