using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosEListas.Models
{
    public class MeuArray<T>// <T> tipo generico o que significa que não tem tipo definido sendo substituido pelo tipo de dado informado
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento)// colocando o tipo generico
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

    }

}