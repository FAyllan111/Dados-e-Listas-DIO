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

new ExemploExcecao.Metodo1();