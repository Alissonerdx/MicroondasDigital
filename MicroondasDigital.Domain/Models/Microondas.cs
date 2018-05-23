using MicroondasDigital.Domain.Constants;
using MicroondasDigital.Domain.Interfaces;
using MicroondasDigital.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Domain.Models
{
    public class Microondas : IMicroondas
    {
        public string Status { get; set; }
        public int? PotenciaAtual { get; private set; }
        public int? TempoAtual { get; private set; }
        public int TempoMaximoSegundos { get; private set; }
        public int TempoMinimoSegundos { get; private set; }
        public int FracaoTempo { get; private set; }
        public int PotenciaMaxima { get; private set; }
        public int PotenciaMinima { get; private set; }

        public MicroondasValidation Validacao { get; private set; }

        public Microondas(string configuracao)
        {

        }

        public Microondas(int tempoMaximoSegundos = 120, 
               int tempoMinimoSegundos = 1,
               int fracaoTempo = 1, 
               int potenciaMaxima = 10,
               int potenciaMinima = 1
        )
        {
            TempoMaximoSegundos = tempoMaximoSegundos;
            TempoMinimoSegundos = tempoMinimoSegundos;
            FracaoTempo = fracaoTempo;
            PotenciaMaxima = potenciaMaxima;
            PotenciaMinima = potenciaMinima;
            PotenciaAtual = PotenciaMaxima;
            Validacao = new MicroondasValidation(this);
        }

        public void DefinirPotencia(int potencia)
        {
            Validacao.DefinirPotencia(potencia);

            if(Validacao.IsValid())
            {
                PotenciaAtual = potencia;
            }
        }

        public void DefinirTempo(int tempoSegundos)
        {
            Validacao.DefinirTempo(tempoSegundos);

            if (Validacao.IsValid())
            {
                TempoAtual = tempoSegundos;
            }
        }

        public void AumentarPontencia()
        {
            Validacao.AumentarPontencia();

            if (Validacao.IsValid())
            {
                PotenciaAtual++;
            }
        }

        public void DiminuirPotencia()
        {
            Validacao.DiminuirPotencia();

            if(Validacao.IsValid())
            {
                PotenciaAtual--;
            }
        }

        public void IniciarAquecimento()
        {
            Validacao.IniciarAquecimento();

            if (Validacao.IsValid())
            {
                Status = TipoStatus.AQUECENDO;
            }
        }

        public bool Valido()
        {
            throw new NotImplementedException();
        }

        public void InicioAquecimentoRapido()
        {
            Validacao.InicioAquecimentoRapido();

            if(Validacao.IsValid())
            {
                TempoAtual = 30;
                PotenciaAtual = 8;
            }
        }
    }
}
