using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class Conta
    {
        public double saldo { get; protected set; }

        public void deposita(double valor) {
            this.saldo += valor;
        }

        public virtual void saca(double valor) {
            this.saldo = saldo - valor - 1;
        }

    }

    public class Especial: Conta {
        public override 
    }

}