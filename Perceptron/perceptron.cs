using System;

namespace Perceptron
{
    public class perceptron
    {
        int Entradas = 4;
        int Salidas = 2;
        int[,] PatronEntrada = new int[4, 4] { { 1, 0, 1, 0 }, { 0, 1, 0, 1 }, { 0, 0, 1, 1 }, { 0, 1, 0, 0 } };
        int[,] PatronSalida = new int[4, 2] { { 1, 1 }, { 0, 1 }, { 1, 0 }, { 0, 0 } };
        double[,] MatrizDePeso;
        double[] MatrizUmbral;
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("El siguiente programa realizara el entrenamineto");
            Console.WriteLine("de la red Perceptron");
            Console.WriteLine("-------------------------");
            /*Console.WriteLine("En primer lugar dijite los parametros");
            Console.WriteLine("Entradas:");
            Entradas = int.Parse(Console.ReadLine());
            Console.WriteLine("Salidas:");
            Salidas = int.Parse(Console.ReadLine());*/

            
        }

        public perceptron(int entradas, int salidas)
        {
            Entradas = entradas;
            Salidas = salidas;

            MatrizDePeso = new double[entradas, salidas];
            MatrizUmbral = new double[salidas];

            LlenarMatrizdePeso();
        }

        public void LlenarMatrizdePeso()
        {
            Random random = new Random();
            for (var i = 0; i < Salidas; i++)
            {
                for (var j = 0; j < Entradas; j++)
                {
                    if (random.Next(0, 1) == 0)
                    {
                        MatrizDePeso[j, i] = -1 * random.NextDouble();
                    }
                    else
                    {
                        MatrizDePeso[j, i] = random.NextDouble();
                    }
                }
            }

            for (int k = 0; k < MatrizDePeso.GetLength(0); k++)
            {
                for (int m = 0; m < MatrizDePeso.GetLength(1); m++)
                {
                    Console.WriteLine($"{MatrizDePeso[k, m]}");
                }
                Console.WriteLine();
            }
        }

        private void LlenarMatrizUmbral()
        {
            Random random = new Random();
            for (var i = 0; i < Salidas; i++)
            {
                if (random.Next(0, 1) == 0)
                {
                    MatrizUmbral[i] = -1 * random.NextDouble();
                }
                else
                {
                    MatrizUmbral[i] = random.NextDouble();
                }
            }
        }

    }
}
