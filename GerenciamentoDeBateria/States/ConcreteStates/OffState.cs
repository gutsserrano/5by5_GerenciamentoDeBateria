using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeBateria.States;

namespace GerenciamentoDeBateria.States.ConcreteStates
{
    internal class OffState : State
    {
        public OffState(int battery)
        {
            if (battery > 100)
                battery = 100;
            _battery = battery;
        }

        public override void ClickOnOffButton()
        {
            ColoredText("\t[ DESLIGADO ]\n");
            Console.WriteLine("Vou ligar...");
            _notebook.TransitionTo(new OnState(_battery));
        }

        public override void PutCharger()
        {
            ColoredText("\t[ DESLIGADO ]\n");
            Console.WriteLine("Vou carregar...");
            _notebook.TransitionTo(new ChargingState(_battery));
        }

        public override void RemoveCharger()
        {
            ColoredText("\t[ DESLIGADO ]\n");
            Console.WriteLine("Não estou sendo carregado!");
            return;
        }

        public override void CheckBattery()
        {
            ColoredText("\t[ DESLIGADO ]\n");
            Console.WriteLine($"Porcentagem de bateria: {_battery}%");
            return;
        }

        public override void PrintStateName()
        {
            ColoredText("\t[ DESLIGADO ]\n");
        }

        private void ColoredText(string text)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
