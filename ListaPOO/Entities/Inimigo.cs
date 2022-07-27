using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Entities
{
    public abstract class Inimigo
    {
        public string Nome { get; set; }
        public float Vida { get; set; } = 100;

        public string Atacar()
        {
            return "Inimigo atacou";
        }
        public string Defender()
        {

            return "Inimigo defendeu";
        }
    }
}
