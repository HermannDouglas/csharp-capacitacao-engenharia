using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.interfaces
{
    public interface ICalculadora
    {
        public int soma(int numero_1, int numero_2);
        public int subtrair(int numero_1, int numero_2);
        public int multiplicacao(int numero_1, int numero_2);
        public int divisao(int numero_1, int numero_2);
    }
}