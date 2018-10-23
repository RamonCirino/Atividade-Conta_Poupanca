using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando dois objetos ContaPoupanca

            ContaPoupanca Poupador1 = new ContaPoupanca(2000);
            ContaPoupanca Poupador2 = new ContaPoupanca(3000);

            Console.WriteLine("Dados Poupador 1, saldo = 2000 mil reais");
            Console.WriteLine("      Poupador 2, saldo = 3000 mil reais \n");

            Console.WriteLine("Considere a taxa de Juros à 4%: \n");

            ContaPoupanca.AlterarTaxaDeJuros(0.04);

            Console.WriteLine("Com essa taxa de juros o novo saldo será de:  \n");
            Console.WriteLine("Poupador 1: " + Poupador1.CalcularJuromensal());

            Console.WriteLine("\n");

            Console.WriteLine("Poupador 2: " + Poupador2.CalcularJuromensal());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Saldo atualizado a 4%:\n\nPoupador 1, saldo = 2006,66666666667 mil reais");
            Console.WriteLine("Poupador 2, saldo = 3010 mil reais \n");

            Console.WriteLine("Caso a taxa de Juros seja de 5%: \n");

            ContaPoupanca.AlterarTaxaDeJuros(0.05);

            Console.WriteLine("o novo saldo será de:  \n");
            Console.WriteLine("Poupador 1: " + Poupador1.CalcularJuromensal());

            Console.WriteLine("\n");

            Console.WriteLine("Poupador 2: " + Poupador2.CalcularJuromensal());


            Console.WriteLine("\n");

            Console.WriteLine("Pressione a tecla ENTER para sair . . .");

            Console.ReadKey();

        }
    }
}
        
    

