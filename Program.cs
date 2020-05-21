using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira as medidas dos três lados do seu triângulo, e este programa lhe dirá a área e o semiperímetro do triângulo (Os lados deve estar com a mesma unidade de medida.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Medida do primeiro lado:");
            string lado1 = Console.ReadLine();

            Console.WriteLine("Medida do segundo lado:");
            string lado2 = Console.ReadLine();

            Console.WriteLine("Medida do terceiro lado:");
            string lado3 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            double l1 = Convert.ToDouble(lado1);
            double l2 = Convert.ToDouble(lado2);
            double l3 = Convert.ToDouble(lado3);

            double semiperímetro = l1 + l2 + l3;
            double semiperímetrofinal = semiperímetro / 2;
            
            double pa = semiperímetrofinal - l1;
            double pb = semiperímetrofinal - l2;
            double pc = semiperímetrofinal - l3;
            double resultado = semiperímetrofinal * pa * pb * pc;
            Convert.ToDouble(resultado);
        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A área do seu triângulo é ");
            Console.WriteLine(Math.Sqrt(resultado));
            Console.WriteLine("Medida do semiperímetro = " + semiperímetrofinal);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;



        }
    }
}
