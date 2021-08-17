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
                contas[i].Titular.Nome = $"conta{i}";
                contas[i].Titular.CPF = i+123;
                contas[i].Titular.Profission = $"contaprofissao{i}";
                contas[i].NumeroAgencia = i+456;
                contas[i].NumeroConta = i+789;
                contas[i].Saldo = i + 1;
                contas[i].imprime(); 
            }


        }
    }
}
