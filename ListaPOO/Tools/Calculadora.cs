using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Tools
{
    public static class Calculadora
    {
        public static void Somar(float[] valores)
        {
            //var resultado = valores.Sum();
            try
            {
                float resultado = 0;

                foreach (var valor in valores)
                {
                    resultado += valor;
                }
                //return resultado;
                Console.WriteLine(resultado);
            }
            catch (Exception e)
            {
                //throw new Exception("Valores inválidos");
                Console.WriteLine(e.Message);

            }
        }

        public static void Subtrair(float[] valores)
        {
            float resultado = 0;
            foreach (var valor in valores)
            {
                resultado -= valor;
            }
            //return resultado;
            Console.WriteLine(resultado);
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
        public static void Dividir(float[] valores)
        {


            float resultado = valores[0];
            try
            {
                if (valores.Length == 0)
                {
                    throw new Exception("Não há valores válidos");
                }
                for (int i = 0; i < valores.Length - 1; i++)
                {
                    resultado /= valores[i + 1];
                }
                //return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //return 0;
                //throw new Exception("Revise os valores informados");
            }


        }

        public static void Multiplicar(float[] valores)
        {
            float resultado = 1;
            foreach (var valor in valores)
            {
                resultado *= valor;
            }
            //return resultado;
            Console.WriteLine(resultado);
        }
    }
}
