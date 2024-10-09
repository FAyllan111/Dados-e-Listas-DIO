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

