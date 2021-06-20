namespace DIO.Series
{
    public class Serie : EntidadeBase
     {
         // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set;}
        // Métodos

        public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + System.Environment.NewLine;
            retorno += "Título: " + this.Titulo + System.Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + System.Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + System.Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
     }
}