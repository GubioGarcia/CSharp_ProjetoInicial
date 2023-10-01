using System.Runtime.InteropServices;
using ProjetoInicial.Models;

// Pessoa objPessoa = new Pessoa(); // Instância class Pessoa
// objPessoa.Nome = "Gubio";
// objPessoa.Idade = 23;
// objPessoa.Apresentar();

int x, y, operacao = 0;
Calculadora calc = new Calculadora();

Console.WriteLine("CALCULADORA\n");
Console.WriteLine("\nDigite:\n");
Console.WriteLine("1 para Adicao\n");
Console.WriteLine("2 para Subtracao\n");
Console.WriteLine("3 para Multiplicacao\n");
Console.WriteLine("4 para Divisao\n");
Console.WriteLine(">>: ");

operacao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe os termos da operacao:\n");
Console.WriteLine("Primeiro termo: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Segundo termo: ");
y = Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case 1:
        calc.Adicao(x, y);
        break;
    
    case 2:
        calc.Subtracao(x, y);
        break;

    case 3:
        calc.Multiplicacao(x, y);
        break;

    case 4:
        calc.Divisao(x, y);
        break;

    default:
        Console.WriteLine("\nOperacao Invalida!\n");
        break;
}