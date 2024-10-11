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