/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosListas.Models
    public class Venda
    {       
        public Vendas(int id,string produto,decimal preco)// construtor
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco {get; set; }   
    }
}


Venda v1 = new Vendas(1,"Livro",29.54);

// seraializando

string serializado = JsonConvert.SerializeObject(v1, Formating.Indented);

Console.WriteLine(serializado);


//deserializando 

*/