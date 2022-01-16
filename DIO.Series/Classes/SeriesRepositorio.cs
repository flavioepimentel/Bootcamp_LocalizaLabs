using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        // Listando todas as Series
        private List<Series> listaSerie = new List<Series>();

        // Implementa��es dos Reposit�rios 
        public void Atualiza(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        List<Series> IRepositorio<Series>.Lista()
        {
            return listaSerie;
        }

        Series IRepositorio<Series>.RetornaPorId(int id)
        {
           return listaSerie[id];
        }
    }
}