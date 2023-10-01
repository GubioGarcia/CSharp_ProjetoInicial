using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInicial.Models
{
    public class Calculadora
    {
        public void Adicao (int x, int y) {
            Console.WriteLine($"{x} + {y} = {x + y}\n");
        }

        public void Subtracao (int x, int y) {
            Console.WriteLine($"{x} - {y} = {x - y}\n");
        }

        public void Multiplicacao (int x, int y) {
            Console.WriteLine($"{x} * {y} = {x * y}\n");
        }

        public void Divisao (int x, int y) {
            Console.WriteLine($"{x} / {y} = {x / y}\n");
        }
    }
}