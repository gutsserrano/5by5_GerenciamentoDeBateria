using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeBateria.States;

namespace GerenciamentoDeBateria.States.ConcreteStates
{
    internal class OnState : State
    {
        public OnState(int battery)
        {
            _battery = battery;
        }

        public override void ClickOnOffButton()
        {
            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine("Vou desligar...");
            _notebook.TransitionTo(new OffState(_battery));
        }

        public override void PutCharger()
        {
            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine("Vou carregar...");
            _notebook.TransitionTo(new ChargingState(_battery));
        }

        public override void RemoveCharger()
        {
            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine("Não estou sendo carregado");
            return;
        }

        public override void CheckBattery()
        {
            _battery -= 25;
            if (_battery < 0) _battery = 0;

            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine($"porcentagem de Bateria: {_battery}%");
            if (_battery == 0)
            {
                _notebook.TransitionTo(new NoBatteryState());
            }
        }

        public override void PrintStateName()
        {
            ColoredText("\t[ LIGADO ]\n");
        }

        private void ColoredText(string text)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
