using System.Diagnostics;

namespace DIO.Series
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay())}(),nq}}")]
    public class Series : EntidadeBase
    {
        private Genero genero;
        // ATRIBUTOS
        //genero titulo descricao ano
        private Genero Genero { get => genero; set => genero = value; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        // MÉTODODS
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        // Exibindo dados como string
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + this.Genero + Environment.NewLine;
            retorno += "Titulo" + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano" + this.Ano + Environment.NewLine;
            return retorno
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

    
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

