using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Tools
{
    public static class Calculadora
    {
        public static float Somar(float[] valores)
        {
            //var resultado = valores.Sum();
            float resultado = 0;

            foreach (var valor in valores)
            {
                resultado += valor;
            }
            //return resultado;
            return resultado;
        }

        public static float Subtrair(float[] valores)
        {
            float resultado = 0;
            foreach (var valor in valores)
            {
                resultado -= valor;
            }
            return resultado;
        }

        /// <summary>
        /// Divide todos os elementos entre si. 
        /// Divide o primeiro pelo segundo e o resultado pelo terceiro e assim por diante...
        /// <para>Se houver o valor "zero" entre os elementos do array de Float, o resultado da divisão será "infinito"</para>
        /// <para>Só retorna uma excessão se for inteiro ou decimal</para>
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Resultado da divisão dos elementos no formato <b>float</b></returns>
        /// <exception cref="Exception"></exception>
        public static float Dividir(float[] valores) 
        {
            float resultado = valores[0];
            try
            {
                for (int i = 0; i < valores.Length - 1; i++)
                {
                    resultado /= valores[i+1];
                }
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Revise os valores informados");
            }
        }

        public static float Multiplicar(float[] valores)
        {
            float resultado = 0;
            foreach (var valor in valores)
            {
                resultado *= valor;
            }
            return resultado;
        }
    }
}
