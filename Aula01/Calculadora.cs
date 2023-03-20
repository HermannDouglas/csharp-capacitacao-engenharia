using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula01.interfaces;

namespace Aula01
{
   public class Calculadora : ICalculadora
   {
      public int soma(int numero_1, int numero_2)
      {
         return numero_1 + numero_2;
      }
      public int soma(int numero_1, int numero_2, int numero_3)
      {
         return numero_1 + numero_2 + numero_3;
      }

      public int subtrair(int numero_1, int numero_2)
      {
         return numero_1 - numero_2;
      }
      public int multiplicacao(int numero_1, int numero_2)
      {
         return numero_1 * numero_2;
      }
      public int divisao(int numero_1, int numero_2)
      {
         return numero_1 / numero_2;
      }


   }
}