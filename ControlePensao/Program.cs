using System;

namespace ControlePensao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de quartos:");
            int n = int.Parse(Console.ReadLine());

            Quartos[] Q = new Quartos[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o nome:");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o email:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o numero do quarto:");
                int numQuarto = int.Parse(Console.ReadLine());

                Q[numQuarto] = new Quartos(name,email, numQuarto);
            }
            Console.WriteLine("Quartos Ocupados:");
            for (int i = 0; i < 10; i++) {

                if (Q[i]!= null) {
                    Console.Write(Q[i]);
                }

            }


        }
    }
}
