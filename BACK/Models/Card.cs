using System;

namespace BACK.Models
{
    public class Card
    {
        public Card() {}

        public Card(int id, string titulo, string conteudo, string lista)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Conteudo = conteudo;
            this.Lista = lista;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Lista { get; set; }

        public bool CamposValidos()
        {
            if(string.IsNullOrEmpty(this.Titulo) || string.IsNullOrEmpty(this.Conteudo) || string.IsNullOrEmpty(this.Lista))
                return false;

            return true;
        }

        public void RegistrarAtividade(string tipo)
        {
            switch (tipo)
            {
                case "alterar":
                    System.Console.WriteLine($"{DateTime.Now} - Card {Id} - {Titulo} - Alterar");
                    break;
                case "remover":
                    System.Console.WriteLine($"{DateTime.Now} - Card {Id} - {Titulo} - Remover");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}