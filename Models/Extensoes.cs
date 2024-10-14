using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosEListas.Models
{
    public static class Extensoes
    {
        public static bool EPar(this int numero)//usando o this utiliza o proprio valor atribuido e todos os dados do mesmo tipo vao ter acesso a esse metodo
        {
        return numero % 2 == 0; 
        }
    }
}