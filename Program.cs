using DadosListas.Models;
using Newtonsoft.Json;

// tipos especiais
//null-> ? atribui o valor nulo para a situação
//usado para validar informações que nao foram enviadas

bool? desejaReceberEmail = true;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) // valida se tem valor e o valor do booleano
{
    Console.WriteLine("O usuário deseja receber email.");
}
else 
{
    Console.WriteLine("O usuário não quer receber email ou nã oresondeu ");
}

//anonimos
//variavel que representa valores como leitura

var tipoAnonimo = new { Nome = "dsad", Sobrenome = "sdad", Altura = 1.89 };

Console.WriteLine("Nome:" + tipoAnonimo.Nome);
Console.WriteLine("Sobreome:" + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura:" + tipoAnonimo.Altura);

// variavel dinamica
// variaveis que mudam de tipo conforme o tipo de dado

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo de:{variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Texti";

Console.WriteLine($"Tipo de:{variavelDinamica.GetType()}, Valor: {variavelDinamica}");

//Genericos cria uma classe que não tem especificação de tipo, apenas quando é instanciada, classes como se fossem de tipo dinamicos

//MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(90);

Console.WriteLine(!arrayInteiro[0]);

//metodos de extensão 
// extenter o tipo com um comportamento,adiconar os metodos que 

int numero2 = 15;
bool par = false;

par =numero2.EPar();//chama a extensão de um metodo "personalizada",usada para reaproveitar o que foi feito anteriormente

Console.WriteLine($"o numero{numero2} é "+"(par ? "par" : "impar")");

