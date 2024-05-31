using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeBateria
{
    internal class ChargingState : State
    {
        public ChargingState(int battery)
        {
            this._battery = battery;
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
            this._notebook.TransitionTo(new OffState(this._battery));
        }

        public override void CheckBattery()
        {
            this._battery += 25;
            if (this._battery > 100) this._battery = 100;

            ColoredText("\t[ CARREGANDO ]\n");
            Console.WriteLine($"porcentagem de Bateria: {this._battery}%");
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
