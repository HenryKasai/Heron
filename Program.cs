using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira as medidas dos três lados do seu triângulo, e este programa lhe dirá a área e o semiperímetro do triângulo. Obs.: Em metros.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Medida do primeiro lado:");
            string lado1 = Console.ReadLine();

            Console.WriteLine("Medida do segundo lado:");
            string lado2 = Console.ReadLine();

            Console.WriteLine("Medida do terceiro lado:");
            string lado3 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            decimal l1 = Convert.ToDecimal(lado1);
            decimal l2 = Convert.ToDecimal(lado2);
            decimal l3 = Convert.ToDecimal(lado3);

            decimal semiperímetro = l1 + l2 + l3;
            decimal semiperímetrofinal = semiperímetro / 2;
            
            decimal pa = semiperímetrofinal - l1;
            decimal pb = semiperímetrofinal - l2;
            decimal pc = semiperímetrofinal - l3;
            decimal resultado = semiperímetrofinal * pa * pb * pc;
            Convert.ToDouble(resultado);
            double result = Convert.ToSingle(resultado);
            Convert.ToDecimal(result);
        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A área do seu triângulo é ");
            Console.Write(Math.Sqrt(result));
            Console.WriteLine(" m²");
            Console.WriteLine("Medida do semiperímetro = " + semiperímetrofinal);
            Console.ForegroundColor = ConsoleColor.Gray;



        }
    }
}
