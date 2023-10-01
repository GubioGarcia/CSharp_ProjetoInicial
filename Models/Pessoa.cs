using System; // Fornecce tipos fundamentais e funcionalidades básicas, como manipulação de strings, entrada e saída padrão, exceções e etc.
using System.Collections.Generic; // Fornece tipos genericos para coleções de dados
using System.Linq; // Realiza operações de consultas (query) em coleções de dados
using System.Threading.Tasks; // Fornece tipos e métodos para criar e gerenciar tarefas assíncronas

namespace ProjetoInicial.Models
{
    public class Pessoa
    {
        // Atributos
        public string Nome  { get; set; } = "";
        public int Idade { get; set; }

        // Metodos
        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos.");
        }
    }
}