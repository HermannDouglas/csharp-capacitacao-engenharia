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
            System.Console.WriteLine($"Depositou: {this.saldo}");
        }

        public virtual void saca(double valor) {
            this.saldo = this.saldo - valor - 1;
            this.saldo = Math.Round(this.saldo, 2);
            System.Console.WriteLine($"Sacou: {valor} -> Taxa: 1,00 -> Saldo: {this.saldo}");
        }
        public virtual void saca(double valor, double taxa){
            this.saldo = this.saldo - valor - (valor * taxa)/100;
            this.saldo = Math.Round(this.saldo, 2);
            System.Console.WriteLine($"Sacou: {valor} -> Taxa: {taxa}% -> saldo: {this.saldo}");
        }


    }

    public class Especial: Conta {
        public override void saca(double valor)
        {
             this.saldo = this.saldo - valor -3;
        }
    }


}