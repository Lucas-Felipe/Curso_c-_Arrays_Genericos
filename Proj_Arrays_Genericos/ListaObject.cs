using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proj_Arrays_Genericos
{
    public class ListaObject<T>
    {
        private T[] _lista;
        private int _proximo;

        public ListaObject()
        {
            _lista = new T[] { };
            _proximo = 0;
        }

        public void Add(T conta)
        {
            VerificaCapacidade(_proximo + 1);
            for (int i = 0; i < _lista.Length; i++)
            {
                if (conta.Equals(_lista[i]))
                {
                    Console.WriteLine("\nJá existe uma conta igual!");
                    return;
                }

            }
            _lista[_proximo] = conta;
            _proximo++;
            Console.WriteLine(conta.ToString());
            Console.WriteLine("\nConta adicionada com sucesso!");
        }

        private void VerificaCapacidade(int tamanho)
        {
            if (_lista.Length >= tamanho)
            {
                return;
            }

            T[] novoarray = new T[tamanho];
            for (int i = 0; i < _lista.Length; i++)
            {
                novoarray[i] = _lista[i];
            }
            _lista = novoarray;
        }

        public void imprime()
        {
            for (int i = 0; i < _lista.Length; i++)
            {
                if (_lista[i] == null)
                    break;
                Console.WriteLine(_lista[i].ToString()); 
            }
        }

        public void remove(T itemexcluido)
        {
            int indice = -1;
            for (int i = 0; i < _proximo; i++)
            {
                T atual = _lista[i];
                if (atual.Equals(itemexcluido))
                {
                    indice = i;
                    break;
                }
            }


            for (int i = indice; i < _proximo - 1; i++)
            {
                _lista[i] = _lista[i + 1];
            }

            _proximo--;
            _lista[_proximo] = default;
        }

        public void AddVarios(params T[] contas)
        {

            foreach (T conta in contas)
            {
                Add(conta);
            }

        }

    }
}
