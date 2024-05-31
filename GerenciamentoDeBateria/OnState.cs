using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeBateria
{
    internal class OnState : State
    {
        public OnState(int battery)
        {
            this._battery = battery;
        }

        public override void ClickOnOffButton()
        {
            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine("Vou desligar...");
            this._notebook.TransitionTo(new OffState(this._battery));
        }

        public override void PutCharger()
        {
            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine("Vou carregar...");
            this._notebook.TransitionTo(new ChargingState(this._battery));
        }

        public override void RemoveCharger()
        {
            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine("Não estou sendo carregado");
            return;
        }

        public override void CheckBattery()
        {
            this._battery -= 25;
            if (this._battery < 0) this._battery = 0;

            ColoredText("\t[ LIGADO ]\n");
            Console.WriteLine($"porcentagem de Bateria: {this._battery}%");
            if (this._battery == 0)
            {
                this._notebook.TransitionTo(new NoBatteryState());
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
