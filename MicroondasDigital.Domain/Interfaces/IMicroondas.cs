using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Domain.Interfaces
{
    public interface IMicroondas
    {
        void DefinirPotencia(int potencia);
        void DefinirTempo(int tempoSegundos);
        void AumentarPontencia();
        void DiminuirPotencia();
        void IniciarAquecimento();
        void InicioAquecimentoRapido();
    }
}
