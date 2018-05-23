using MicroondasDigital.Domain.Interfaces;
using MicroondasDigital.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Domain.Validations
{
    public class MicroondasValidation : Validation, IMicroondas
    {
        private Microondas _microondas;

        public MicroondasValidation(Microondas microondas)
        {
            _microondas = microondas;
        }

        public void AumentarPontencia()
        {
            if (_microondas.PotenciaAtual == _microondas.PotenciaMaxima)
                this.AddError("A pontecia não pode ser aumentada, está no maximo!");
        }

        public void DefinirPotencia(int potencia)
        {
            if (potencia < _microondas.PotenciaMinima || potencia > _microondas.PotenciaMaxima)
                this.AddError("A potencia não é valida!");
        }

        public void DefinirTempo(int tempoSegundos)
        {
            if (tempoSegundos < _microondas.TempoMinimoSegundos || tempoSegundos > _microondas.TempoMaximoSegundos)
                this.AddError("O tempo não é valido!");
        }

        public void DiminuirPotencia()
        {
            if (_microondas.PotenciaAtual == _microondas.PotenciaMinima)
                this.AddError("A pontecia não pode ser diminuida, está no minimo!");
        }

        public void IniciarAquecimento()
        {
            if (_microondas.TempoAtual == null)
                this.AddError("O tempo deve ser definido antes de iniciar o aquecimento!");
        }

        public void InicioAquecimentoRapido()
        {
            throw new NotImplementedException();
        }
    }
}
