using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{


    class Program
    {

        public static List<T> CopiaApos<T>(List<T> lista, int indexCorte)
        {
            List<T> ret = new List<T>(); 
            for(int i = indexCorte; i < lista.Count; i++)
            {
                ret.Add(lista[i]); 
            }
            return ret; 
        }


        static void Main(string[] args)
        {
            List<int> listaDeNumeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            List<int> cortada = CopiaApos<int>(listaDeNumeros, 3);

            foreach(int numero in cortada)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
