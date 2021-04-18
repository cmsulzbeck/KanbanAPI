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

    }
}