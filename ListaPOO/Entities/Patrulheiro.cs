using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Entities
{
    public class Patrulheiro : Inimigo
    {
        public Patrulheiro(float velocidade)
        {
            Velocidade = velocidade;
        }

        public bool Perseguidor { get; set; }
        public float Velocidade { get; set; }
        public string Patrulhar()
        {
            return "Inimigo patrulheiro está realizando a patrulha";
        }
    }
}
