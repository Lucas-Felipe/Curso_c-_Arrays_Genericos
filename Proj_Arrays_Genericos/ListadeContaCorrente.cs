using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Proj_Arrays_Genericos
{
    public class ListadeContaCorrente
    {
        private ContaCorrente[] _lista;
        private int _proximo;

        public ListadeContaCorrente()
        {
            _lista = new ContaCorrente[] { };
            _proximo = 0;
        }

        public void Add(ContaCorrente conta)
        {
            VerificaCapacidade(_proximo+1);
            _lista[_proximo] = conta;
            _proximo++;
        }

        private void VerificaCapacidade(int tamanho)
        {
            if (_lista.Length>=tamanho)
            {
                return;
            }

            ContaCorrente[] novoarray = new ContaCorrente[tamanho];
            for (int i = 0; i < _lista.Length; i++)
            {
                novoarray[i] = _lista[i];
            }
            _lista = novoarray;
        }

        public void imprime() 
        {
            for (int i=0;i<_lista.Length;i++)
            {
                if (_lista[i] == null)
                    break;
                _lista[i].imprime();
            }
        }

        public void remove(ContaCorrente itemexcluido)
        {
            int indice = -1;
            for (int i = 0; i < _proximo; i++)
            {
                ContaCorrente atual = _lista[i];
                if (atual.Equals(itemexcluido))
                {
                    indice = i;
                    break;
                }
            }


            for (int i = indice; i < _proximo-1; i++)
            {
                _lista[i] = _lista[i + 1];
            }

            _proximo--;
            _lista[_proximo] = null;
        }
    }
}
