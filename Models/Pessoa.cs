using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosListas.Models
{
    public class Pessoa
    {
        //construtores por padrão ficam nas primeiras linhas da classe; todo construtor tem o mesmo nome da classe, e nao tem um tipo de retorno, e recebe alguns parametros ou é vazio ou as informações inseridas
        public Pessoa() // valor padrao
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            //define os valores padrão dentro do construtor
        }



        //Propriedades , sao as caracteristicas que vão ser usadas
        // vazio => aceita qualquer valor

        // sem validação

        //public string Nome { get; set ;}
        //public int Idade { get; set ;}


        //campo para validação:

        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            } 

            // usando body expressions [=>] substitui o return preferivel usar
            // get => _nome.ToUpper(); 

            set 
            { 
                if (value == "")
                {
                    throw new ArgumentException("o nome não pode está vazio");
                }

                _nome = value;
            } 
        
        }

        
        public string Sobrenome { get; set;}
        // propriedade apenas para leitura apenas get
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");

                }

                _idade = value;
            } 
        }


        // metodo, são as açoes que vai ser realizada, instruções para serem realizadas e podem ser reaproveitados
        public void Apresentar()
        {
            Console.WriteLine($"Sou {NomeCompleto} e tenho {Idade} anos.");
        }
        
    }
}