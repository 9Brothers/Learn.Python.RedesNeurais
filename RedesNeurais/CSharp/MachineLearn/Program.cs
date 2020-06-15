using System;
using System.Linq;

namespace MachineLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var entradas = new double[4, 2] { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };
            var saidas = new double[] { 0, 1, 1, 0 };

            var pesos0 = new double[2, 3] { { -0.424, -0.740, -0.961 }, { 0.358, -0.577, -0.469 } };
            var pesos1 = new double[] { -0.017, -0.893, 0.148 };

            var epocas = Enumerable.Range(0, 1000000);
            var taxaAprendizagem = 0.3;
            var momento = 1;
            var mediaAbsoluta = 0.0;

            foreach (var i in epocas)
            {
                var camadaEntrada = entradas;
                var somaSinapse0 = Dot(camadaEntrada, pesos0);
                var camadaOculta = Sigmoid(somaSinapse0);

                var somaSinapse1 = Dot(camadaOculta, pesos1);
                var camadaSaida = Sigmoid(somaSinapse1);

                var erroCamadaSaida = Subtract(saidas, );
            }
        }

        static double[,] Dot(double[,] entradas, double[,] pesos)
        {
            var saida = new double[,] {};

            for (int i = 0; i < entradas.Length; i++)
            {
                for (int j = 0; j < pesos.Length; j++)
                {
                    saida[i, j] = entradas[i, j] * pesos[i, j];
                }
            }

            return saida;
        }

        static double[,] Sigmoid(double[,] somaSinapse)
        {
            var sigmoid = new double[,] { };

            foreach (var i in somaSinapse)
            {
                foreach (var j in i)
                {
                    
                }


                sigmoid.Append(soma.Select(s => 1 / (1 + Math.Exp(-s))).ToArray());
            }

            return sigmoid;
        }

        static double[] SigmoidDerivada(double[] sigmoid)
        {
            return sigmoid.Select(s => s * (1 - s)).ToArray();
        }

        static double[] Subtract(double[] first, double[] second)
        {
            var subtract = new double[] { };

            if (first.Length != second.Length)
                throw new Exception("Os dois arrays precisam ter o mesmo tamanho");

            for (int i = 0; i < first.Length; i++)
            {
                subtract.Append(first[i] - second[i]);
            }

            return subtract;
        }
    }
}
