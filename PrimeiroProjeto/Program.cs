using System;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("First backend desenvolviment");

            sbyte x = 100;
            Console.WriteLine(x);

            //RETORNA O VALOR 0 - POR CONTA DO OVERFLOW
            byte n1 = 255;
            n1++;
            Console.WriteLine(n1);  
            
            int n2 = -126;
            Console.WriteLine(n2);
            Console.WriteLine(  );
        }
    }
}

//IDENTAÇÃO AUTOMATICA CTRL+K+D
//EXECUTAR CODIGO CTRL+F5
// DUPLICAR LINE CTRL+D