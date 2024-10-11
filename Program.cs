using DadosListas.Models;
using Newtonsoft.Json;

Venda v1 = new Vendas(1,"Livro",29.54);

// seraializando

string serializado = JsonConvert.SerializeObject(v1, Formating.Indented);

Console.WriteLine(serializado);


//deserializando 