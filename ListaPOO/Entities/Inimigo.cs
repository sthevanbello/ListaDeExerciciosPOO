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
        private float Vida = 100;

        public virtual string Atacar()
        {
            return "Inimigo atacou";
        }
        public string Defender()
        {
            Vida -= 5;
            Console.WriteLine($"Defesa realizada!");
            Console.WriteLine($"Vida do inimigo: {Vida}");
            return "Inimigo defendeu";
        }
    }
}
