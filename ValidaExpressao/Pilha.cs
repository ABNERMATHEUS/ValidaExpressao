using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaExpressao.Contratos;

namespace ValidaExpressao
{
    public class Pilha : IPilha
    {

        public char[] _pilha { get; private set; }
        public int _topo { get; private set; }

        public Pilha(int MAX)
        {
            _topo = -1;
            _pilha = new char[MAX];
        }

        public bool cheia()
        {
            return _topo == _pilha.Length - 1;
        }

        public char desempilhar()
        {
            if (vazia())
            {
                throw new Exception("Não é possível desempilhar, porque a pilha está vazia");
            }
            else
            {
                var e = _pilha[_topo];
                _topo =_topo-1;
                return e;
            }


        }

        public void empilhar(char elemento)
        {
            if (cheia())
            {
                throw new Exception("Pilha cheia");
            }
            else
            {
                _topo = _topo+1;
                _pilha[_topo] = elemento;
            }
        }

        public char topo()
        {
            return _pilha[_topo];
        }

        public bool vazia()
        {
            return _topo == -1;
        }
    }
}
