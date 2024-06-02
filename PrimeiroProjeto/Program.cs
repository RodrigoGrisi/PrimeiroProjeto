using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(",");

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = vet[i].Trim(); 
            }

            string p1 = vet[0]; // NOME 
            string p2 = vet[1]; // IDADE 
            string p3 = vet[2]; // PROFISSÃO 
            string p4 = vet[3]; // ATRIBUIÇÃO

            Console.WriteLine($"O funcionario {p1} tem { p2 } e atua como {p3} - {p4} ");
        }
    }
}