using System;
using Modelos;

namespace Proj_Arrays_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[3];

            for (int i = 0; i < contas.Length; i++) 
            {
                contas[i] = new ContaCorrente();
                contas[i].Titular = new Cliente();
                contas[i].imprime();
            }


        }
    }
}
