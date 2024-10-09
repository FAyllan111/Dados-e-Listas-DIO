using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosListas.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        // Coleção uma lista de coisas 
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) // void nao retorna nada no metodo e entre parentesis chama os argumentos (parametro)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
           Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        // todo metodo que retorna informações tem que ter o return
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade; 
            
        } 

    }
}