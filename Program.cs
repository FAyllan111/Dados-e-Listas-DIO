using DadosListas.Models;




/* TRABALHANDO COM PROPRIEDADES
// criando as propriedades
Pessoa p1 = new Pessoa();
//Definindo as propriedades
p1.Nome = "dadad";
p1.Idade = 58;
p1.Sobrenome = "sdadad";

//chamando o metodo com as propriedades setadas
p1.Apresentar();

*/

/*
// TRABALHANDO COM METODOS  

Pessoa p1 = new Pessoa("dsa","dad");
//Definindo as propriedades
Pessoa p2 = new Pessoa("alou", "teste");
//usando metodos construtores


Curso c1 = new Curso();

c1.Nome = "Ingles";
c1.Alunos = new List<Pessoa>();


c1.AdicionarAluno(p1);
c1.AdicionarAluno(p2);
c1.ListarAluno();
*/

/*
//EXCEÇÕES - Try/ catch
// o erro acontece é tratado e o codigo continua



 try
 {     
     string[] texto = File.ReadAllLines("Models/Execcao.txt");

     foreach (string linha in texto)
     {
         Console.WriteLine(linha);
     }
 } catch(Exception ex) // exceção generica
 {
     Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
 }finally{
    // roda independente se tiver exceção ou nao
    Console.WriteLine("Roda independente do try/catch erro");
 }
//  catch(FileNotFoundException ex) // excecao especifica
//  {
//      Console.WriteLine("Arquivo não encontrado"); 
//  }
*/

// TRY/ THROW

//new ExemploExcecao.Metodo1();

//Filas - Queue -> FIFO primeiro que entra primeiro que sai 

//Fila
/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2661);//adicona valores na fila
fila.Enqueue(21);
fila.Enqueue(881);
fila.Enqueue(96374);

foreach (int i in fila) // percorrer a fila
{
    Console.WriteLine(i);
}

fila.Dequeue();// remove o primeiro item da fila

Console.WriteLine($"Removendo o item {fila.Dequeue()}");

foreach (int i in fila) // percorrer a fila
{
    Console.WriteLine(i);
}
*/

/*
//Pilhas - Stack -> LIFO ultimo que entra é o ultimo que sai

Stack<int> pilha = new Stack<int>();

pilha.Push(1); // adiciona itens na pilha
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (int p in pilha)
{
    Console.WriteLine(p);
}


Console.WriteLine($"Removendo o {pilha.Pop()}"); // remove os itens da pilha

foreach (int p in pilha)
{
    Console.WriteLine(p);
}
*/


//dicionarios -> coleção chave valor, onde nao é relacionado ordem. unicos com base na chave que deve ser UNICA

Dictionary<int,string> dicio = new Dictionary<int,string>();


dicio.Add(0,"a");// adicionar itens no dicionario
dicio.Add(1,"b");
dicio.Add(2,"c");
dicio.Add(3,"c");

foreach (var d in dicio)// KeyValuePair<int,string> -> é substituido por var onde os valores em <> tem que ser correspondente aos tipos de chave/valor
{
    Console.WriteLine($"Chave:{d.Key}, Valor: {d.Value}"); // percorrendo o dicionario
}


//remover
dicio.Remove(3);//removendo valores e passa a chave
dicio["b"] = "Valor alterado";// modificar valores

foreach (var d in dicio)
{
     Console.WriteLine($"Chave:{d.Key}, Valor: {d.Value}");
}

// verificando o elemento 

int chave = 2
if (dicio.ContainsKey(chave))
{
    Console.WriteLine("Existe");
}
else{
    Console.WriteLine("Não existe");
}

// obtervalor existente

Console.WriteLine(dicio[2]); //dicio e chave
