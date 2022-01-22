using System;
using System.Collections.Generic;
using DIO.Obras.Interfaces;

namespace DIO.Obras
{
    public class ObrasRepositorio : IRepositorio<Obras>
    {
        // Listando todas as Obras
        private List<Obras> listaObras = new List<Obras>();

        // Implementa��es dos Reposit�rios 
        public void Atualiza(int id, Obras entidade)
        {
            listaObras[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaObras[id].Excluir();
        }
        public void Insere(Obras entidade)
        {
            listaObras.Add(entidade);
        }

        public List<Obras> Lista()
        {
            return listaObras;
        }
        public int ProximoId()
        {
            return listaObras.Count;
        }
        public Obras RetornaPorId(int id)
        {
            return listaObras[id];
        }

        Obras IRepositorio<Obras>.RetornaPorId(int id)
        {
           return listaObras[id];
        }
    }
}