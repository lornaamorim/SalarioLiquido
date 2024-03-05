using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Salário bruto do funcionário: ");
            double salbruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do vale alimentação: ");
            double valeali = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de filhos do funcionário: ");
            double qntfil = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por filho: ");
            double valorfil = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de hora extra: ");
            double hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora extra: ");
            double valorhr = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do INSS: ");
            double inss = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do  IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double resultado = salbruto + valeali + (qntfil * valorfil) + (valorhr + hora) - inss - irpf;

            Console.WriteLine("O salário liquído do funcionário é: " + resultado.ToString("C"));

            Console.ReadKey();

                

        }
    }
}
