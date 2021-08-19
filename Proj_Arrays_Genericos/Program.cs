using System;
using Modelos;

namespace Proj_Arrays_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaObject<object> lista = new ListaObject<object>();

            ContaCorrente a = new ContaCorrente("lucas", 123, "sô istudante", 456, 789);
            ContaCorrente b = new ContaCorrente("pedro", 456, "vagaba", 7789, 9787);
            ContaCorrente c=  new ContaCorrente("paulo", 456, "vagaba", 7789, 9787);
            ContaCorrente d=  new ContaCorrente("adelaide", 456, "desempregada", 7789, 9787);
            ContaCorrente e=  new ContaCorrente("pai", 456, "trabalhador", 7789, 9787);
            ContaCorrente f = new ContaCorrente("chacon", 456, "trabalhador", 7789, 9787);

            lista.AddVarios(a,b,c,d,e,f,f);
            lista.imprime();
            Console.WriteLine("\n\n");
            lista.remove(f);
            lista.imprime();
        }
    }
}
