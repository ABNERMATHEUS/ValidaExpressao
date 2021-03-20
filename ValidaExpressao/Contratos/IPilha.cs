using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaExpressao.Contratos
{
    public interface IPilha
    {
        char topo();

        bool vazia();

        bool cheia();

        void empilhar(char elemento);

        char desempilhar();

    }
}
