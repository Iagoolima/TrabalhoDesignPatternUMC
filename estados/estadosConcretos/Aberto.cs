using System;
using System.Threading;

namespace TrabalhoDesignPatternUMC.estados.estadosConcretos
{
    public class Aberto : Estado
    {
        private Timer _timer;
        private readonly int _tempoTotal = 10;
        private int _tempoRestante;

        public Aberto()
        {    
            _tempoRestante = _tempoTotal;
            _timer = new Timer(MudarParaFechado, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        public override bool Handle1()
        {
            _timer.Dispose(); 
            this._context.TransitionTo(new Fechado());
            return false;
        }

        private void MudarParaFechado(object state)
        {
            _tempoRestante--;
            if (_tempoRestante == 0)
            {
                _timer.Dispose(); 
                this._context.TransitionTo(new Fechado());
            }
        }
        
        public override void ExibirTimer()
        {
            Console.WriteLine($"Servidor em manutencao: Tente novamente após {_tempoRestante} segundos.");
        }
    }
}