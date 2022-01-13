using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        //1-Definindo
        private List<Series> listaSerie = new List<Series>();
        
        public void Atualiza(int id, Series objeto)
        {
            listaSerie[id] = objeto;

        }

        public void Exclui(int id)
        {
            listaSerie.RemoveAt(id)
        }

        public void Insere(Serie)
    }
}