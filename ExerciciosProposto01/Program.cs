using System;
using System.Globalization;

namespace ExerciciosProposto01 {
    class URI {
        static void Main(string[] args) {

            int n;

            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            string[] valor = Console.ReadLine().Split(' ');


            for(int i = 0; i < n; i++) {
                vet[i] = double.Parse(valor[i],CultureInfo.InvariantCulture);
            }

            double maior = vet[0];

            int posicaoMaior = 0;

            for(int i = 1; i < n; i++) {
                if(vet[i] > maior) {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}


