using System;
using Modelos;

namespace Proj_Arrays_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            ListadeContaCorrente lista = new ListadeContaCorrente();

            lista.Add(new ContaCorrente("lucas",123,"sô istudante",456,789));
            lista.Add(new ContaCorrente("pedro", 456, "vagaba", 7789, 9787));
            lista.Add(new ContaCorrente("pedro", 456, "vagaba", 7789, 9787));
            lista.Add(new ContaCorrente("pedro", 456, "vagaba", 7789, 9787));
            lista.Add(new ContaCorrente("pedro", 456, "vagaba", 7789, 9787));
            lista.Add(new ContaCorrente("pedro", 456, "vagaba", 7789, 9787));

            lista.remove(new ContaCorrente("lucas", 123, "sô istudante", 456, 789));
            lista.imprime();
            //for (int i = 0; i < contas.Length; i++) 
            //{
            //    contas[i] = new ContaCorrente($"conta {i}",123+i,$"profission {i}",456+i,789+i);

            //    contas[i].imprime();
            //}

            
        }
    }
}
