using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Entities
{
    internal class Voador : Inimigo
    {
        public int Asas { get; set; }
        public float AlturaMax { get; set; }

        public override string Atacar()
        {
            AlturaMax += 15;
            return "O inimigo aéreo atacou com sucesso, agora ele pode voar mais alto";
        }
        public string Subir()
        {
            return "Inimigo voador está subindo";
        }
        public string Descer()
        {
            return "Inimigo voador está descendo";
        }
    }
}
