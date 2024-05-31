using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeBateria
{
    internal class OffState : State
    {
        public OffState(int battery)
        {
            if (battery > 100)
                battery = 100;
            this._battery = battery;
        }

        public override void ClickOnOffButton()
        {
            ColoredText("\t[ DESLIGADO ]\n");
            Console.WriteLine("Vou ligar...");
            this._notebook.TransitionTo(new OnState(this._battery));
        }

        public override void PutCharger()
        {
            ColoredText("\t[ DESLIGADO ]\n");
            Console.WriteLine("Vou carregar...");
            this._notebook.TransitionTo(new ChargingState(this._battery));
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
            Console.WriteLine($"Porcentagem de bateria: {this._battery}%");
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
