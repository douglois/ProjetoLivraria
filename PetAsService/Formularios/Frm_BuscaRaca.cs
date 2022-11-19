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
using System.IO;
using PetAsService.Classes;

namespace PetAsService
{
    public partial class Frm_BuscaRaca : Form
    {
        List<DadosGato> dadosGatoList;
        int itemCombo = 0;
        int controleCombo = 0;

        public Frm_BuscaRaca()
        {
            InitializeComponent();

            lblSelecionaRaca.Text = "Raça do Gato";
            lblTemperamento.Text  = "Temperamento: ";
            lblDescricao.Text     = "Descrição: ";
            lblOrigem.Text        = "Origem: ";
            lblLife.Text = "Expectativa de Vida: ";
            lblPeso.Text = "Peso";
            lblTextoBuscaRaca.Font = new Font(lblTextoBuscaRaca.Font, FontStyle.Bold);
            lblTextoBuscaRaca.Text = "Encontre sua raça favorita";
            //lblDescBuscaRaca.Text = "Utilize a caixa de seleção, para encontrar diversas raças e veja o que as tornam unicas.";
            lblResultadoLife.Text = "";
            lblResultadoOrigem.Text = "";
            lblResultadoPeso.Text = "";
            panel1.BackColor = Color.FromArgb(206, 161, 139);
            pictureBox1.BackColor = Color.FromArgb(206, 161, 139);
            txtTemperamento.BackColor = Color.FromArgb(206, 161, 139);
            txtDescricao.BackColor = Color.FromArgb(206, 161, 139);
            txtDescricao.ReadOnly = true;
            txtImageUrl.ReadOnly = true;
            txtImageUrl.BackColor = Color.FromArgb(206, 161, 139);
            txtTemperamento.ReadOnly = true;
            dadosGatoList = JsonConvert.DeserializeObject<List<DadosGato>>(BuscaJson.GetJson());
            btnBuscar.Enabled = false;
            btnFavoritar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            itemCombo = cmbSelecionaRaca.SelectedIndex;

            if (cmbSelecionaRaca.SelectedIndex == itemCombo)
            {
                lblResultadoOrigem.Text = dadosGatoList[itemCombo].origin ;
                txtTemperamento.Text = dadosGatoList[itemCombo].temperament;
                pictureBox1.Visible = true;
                txtDescricao.Text = dadosGatoList[itemCombo].description;
                lblResultadoPeso.Text = dadosGatoList[itemCombo].weight.metric;
                
                lblResultadoLife.Text = dadosGatoList[itemCombo].life_span;

                if (dadosGatoList[itemCombo].description.Length > 260)
                {  
                    txtDescricao.ScrollBars = ScrollBars.Vertical;
                    txtDescricao.WordWrap = true;
                    txtDescricao.AcceptsReturn = true;
                    txtDescricao.AcceptsTab = true;
                }
                else
                {
                    txtDescricao.ScrollBars = ScrollBars.None;
                }

                if (dadosGatoList[itemCombo].image.url != null )//&& dadosGatoList[itemCombo].image_url != null)
                {
                    pictureBox1.ImageLocation = dadosGatoList[itemCombo].image.url;
                    txtImageUrl.Text = dadosGatoList[itemCombo].image.url;
                    lblImagemIndisponivel.Enabled = false;
                    lblImagemIndisponivel.Visible = false;
                }
                else
                {
                    lblImagemIndisponivel.Enabled = true;
                    lblImagemIndisponivel.Visible = true;
                    lblImagemIndisponivel.Text = "Imagem indisponivel";
                    txtImageUrl.Text = "Link Indisponivel";
                    pictureBox1.Visible = false;
                }
            }
        }

        private void cmbSelecionaRaca_DropDown(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnFavoritar.Enabled = true;

            if (controleCombo == 0)
            {
                foreach (var item in dadosGatoList)
                {
                    cmbSelecionaRaca.Items.Add(item.name);
                }
                controleCombo++;
            }
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            DadosGato d = new DadosGato();

            DialogResult result = MessageBox.Show("Deseja favoritar a raça " + dadosGatoList[itemCombo].name + "?", "Cat as Service", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Fichario fichario = new Fichario("C:\\Users\\dlois\\Desktop\\Estudos\\C#_Forms\\PetAsService\\Fichario");
                d = LeituraFormulario();

                string gatoFavorito = JsonConvert.SerializeObject(d);
                if (fichario.status)
                {
                    fichario.Incluir(d.name, gatoFavorito);
                    if (fichario.status)
                    {
                        MessageBox.Show("OK: " + fichario.mensagem, "Cat as Service", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + fichario.mensagem, "Cat as Service", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: " + fichario.mensagem, "Cat as Service", MessageBoxButtons.OK);
                }
            }
        }

        DadosGato LeituraFormulario()
        {
            DadosGato d = new DadosGato();

            d.name = dadosGatoList[itemCombo].name;
            d.temperament = txtTemperamento.Text;
            d.origin = lblResultadoOrigem.Text;
            d.description = txtDescricao.Text;
            d.life_span = lblResultadoLife.Text;
            d.weight.metric = lblResultadoPeso.Text;
            d.image.url= txtImageUrl.Text;
            d.weight.metric = lblResultadoPeso.Text;
            return d;
        }

        public void EscreveFormulario(DadosGato d)
        {
            txtTemperamento.Text = d.temperament;
            lblResultadoOrigem.Text = d.origin;
            lblResultadoLife.Text = d.life_span;
            lblResultadoPeso.Text = d.weight.metric;
            txtDescricao.Text = d.description;
            txtImageUrl.Text = d.image.url;
            pictureBox1.ImageLocation = d.image.url;
            cmbSelecionaRaca.Text = d.name;
        }

        private void Frm_BuscaRaca_Load(object sender, EventArgs e)
        {

        }
    }
}
