using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetAsService.Classes
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Diretorio criado com sucesso!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Diretorio não criado com sucesso!" + ex.Message;
            }
        }

        public void Incluir(string raca, string json)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + raca + ".json"))
                {
                    status = false;
                    mensagem = "Esse peludinho já faz parte dos seus favoritos. Não é possivel adicionar novamente =(";
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + raca + ".json", json);
                    status = true;
                    mensagem = "Parabens, voce favoritou a raça " + raca + ", com sucesso!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Diretorio não criado com sucesso!" + ex.Message;
            }
        }

        public void ExcluirFavorito(string raca)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + raca + ".json")))
                {
                    status = false;
                    mensagem = "Raça não encontrada";
                }
                else
                {
                    File.Delete(diretorio + "\\" + raca + ".json");
                    status = true;
                    mensagem = "Exclusao da raça " + raca + " realizada com sucesso: ";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro: Exclusao nao realizada !" + ex.Message;
            }
        }

        public List<string> BuscarFavoritos()
        {
            status = true;
            List<string> list = new List<string>();

            try
            {
                var arquivos = Directory.GetFiles(diretorio, "*.json");

                for (int i = 0; i <= arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(arquivos[i]);
                    list.Add(conteudo);
                }
                return list;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro durante a busca " + ex.Message;
            }
            return list;
        }

        public string BuscarGato(string raca)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + raca + ".json")))
                {
                    status = false;
                    mensagem = "Raça não encontrada";
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + raca + ".json");
                    status = true;
                    mensagem = "Raça encontrada";
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao encontrar raça: " + raca + ex.Message;
            }
            return "";
        }
    }
}
