using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosListas.Models
{
    public class LerArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivos(string caminho) // tupla retornando 3 informações diferentes
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
            }

        }

    }
}

/*
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso,linhasArquivo, quantidadeLinhas) = arquivo.LerArquivos("Models/Execao.txt"); // retornando a tupla usa var para identificar automaticamente os tipos de valores

if (sucesso)
{
    Console.WriteLine("Quantidade de linhas:" + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}

*/


/*
//TUPLAS

// declarando
//tipos de dados e depois valores,obedeçendo os valores definidos
(int Id, string Nome, string Sobrenome ,decimal Altura) tupla = (1, "Nome", "Sobrenome",1.85M);

// outra maneira de criar, devantagem que nao consegue nomear o objeto, ou seja nao da pra identificar o que é cada elemento definido e chama os elementos por .Itemx
ValueTuple<int, string, decimal> tupla2 = (1, "v", 2.58M);// identifica o tipo
var tupla3 = Tuple.Create(1, "a", "b", 69.59M);// tipo definido automaticamente


//Exibindo
//quando nao quiser declarar classes pode-se usar tuplas

Console.WriteLine($" id:{tupla.Id}");
Console.WriteLine($" nome:{tupla.Nome}");
Console.WriteLine($" sobrenome:{tupla.Sobrenome}");
Console.WriteLine($" altura:{tupla.Altura}");
*/

//para descartar as informações usa-se _ onde opta por nao utilizar

// IF vs IF ternário

/* 
int numero = 20;

if (numero % 2== 0)
{
    Console.WriteLine("numero par");
}
else 
{
    Console.WriteLine("numero Impar");
}

//IF ternario

int numero2 = 15;
bool par = false;

par = numero % 2 == 0;

Console.WriteLine($"o numero{numero2} é "+"(par ? "par" : "impar")");

*/