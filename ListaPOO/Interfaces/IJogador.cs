using ListaPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Interfaces
{
    public interface IJogador
    {
        EAcoes Acoes { get; set; }
        string Nome { get; set; }
        float Vida { get; set; }

        void TrocarAcao();
        string Morrer();
    }
}
