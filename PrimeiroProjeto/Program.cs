using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void EntradaDeDados(string[] args) {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço do seu produto: ");
            string preco = Console.ReadLine();

            Console.Write("Digite a sua Altura: ");
            double altura = double.Parse(Console.ReadLine());


            Console.WriteLine($"{nome} , tem {idade} , o preço do seu produto " +
                $" é de R$ {preco} e sua altura é {altura.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}m.");

        }

        static void EntradaSoma(string[] args) {

            int value1, value2, soma;

            Console.Write("Digite o primeiro valor: ");
            value1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            value2 = int.Parse(Console.ReadLine());

            soma = value1 + value2;

            Console.WriteLine(soma);

        }

        static void EstrturaSequencial(string[] args) {

            Console.WriteLine("Digite o valor do raio do circulo: ");
            double value = double.Parse(Console.ReadLine());
            double TT = 3.14159;// subistiuir pelo PI

            //FORMULA DA AREA 
            double result = Math.PI * Math.Pow(value, 2);

            Console.WriteLine($"O valor da area deste circulo é de {result.ToString("F4", CultureInfo.InvariantCulture)}");

        } 
        static void OperadoresComparativos(string[] args) {
            

            int value1 = 20;
            int value2 = 10; 
            
            int value3 = 25;
            double value4 = 25;

            bool c1 = (value1 < value2);
            bool c2 = (value3 != value4);

            Console.WriteLine(c1);
            Console.WriteLine(c2);


        }

        static void Main(string[] args) { }
    }
}