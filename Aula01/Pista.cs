using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class Pista
    {
        public int id { get; set; }
        public string? clima { get; set; }
    }

    public class Treino: Pista{
        public int barreiras { get; set; }
    }
}