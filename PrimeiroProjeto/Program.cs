using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            /* Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine(areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X", areaX);
            }
            else
            {
                Console.WriteLine("Maior área: Y", areaY);
            } 
            */

            Pessoa person1, person2;

            person1 = new Pessoa();
            person2 = new Pessoa();

            Console.WriteLine("Digite o seu nome: ");
            person1.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            person1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu nome: ");
            person2.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            person2.idade = int.Parse(Console.ReadLine());

            if (person1.idade > person2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {person1.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {person2.nome}");
            }

            Console.WriteLine($"seja bem vindos (a) {person1.nome} e {person2.nome}");

        }

    };
};