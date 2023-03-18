using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class Carro
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public double veloxMax { get; set; }

        public void alterar(double a){
            veloxMax = a;
        }

    }
}