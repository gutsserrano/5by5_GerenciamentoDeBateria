using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeBateria.States;

namespace GerenciamentoDeBateria.States.ConcreteStates
{
    internal class ChargingState : State
    {
        public ChargingState(int battery)
        {
            _battery = battery;
        }

        public override void ClickOnOffButton()
        {
            ColoredText("\t[ CARREGANDO ]\n");
            Console.WriteLine("Remova o carregador para poder ligar o Notebook!");
            return;
        }

        public override void PutCharger()
        {
            ColoredText("\t[ CARREGANDO ]\n");
            Console.WriteLine("Um carregador já está conectado!");
            return;
        }

        public override void RemoveCharger()
        {
            ColoredText("\t[ CARREGANDO ]\n");
            Console.WriteLine("removendo carregador...");
            _notebook.TransitionTo(new OffState(_battery));
        }

        public override void CheckBattery()
        {
            _battery += 25;
            if (_battery > 100) _battery = 100;

            ColoredText("\t[ CARREGANDO ]\n");
            Console.WriteLine($"porcentagem de Bateria: {_battery}%");
        }

        public override void PrintStateName()
        {
            ColoredText("\t[ CARREGANDO ]\n");
        }

        private void ColoredText(string text)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
