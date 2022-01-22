using System;
using System.Diagnostics;

namespace DIO.Obras
{
   
    public class Obras : EntidadeBase
    {
        private Genero genero;

        public int Id { get; }

        // ATRIBUTOS
        //genero titulo descricao ano
        private Genero Genero { get => genero; set => genero = value; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        private Categoria Categoria { get; set; }
        private string Elenco { get; set;}



        // M�TODODS
        public Obras(int id, Genero genero, string titulo, string descricao, int ano, Categoria categoria, string elenco)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Categoria = categoria;
            this.Elenco = elenco;
        }

        // Exibindo dados como string
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Categoria: " + this.Categoria + Environment.NewLine;
            retorno += "Elenco: " + this.Elenco + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;

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

        public bool retornaExcluido(){
            return this.Excluido;
        }


        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

