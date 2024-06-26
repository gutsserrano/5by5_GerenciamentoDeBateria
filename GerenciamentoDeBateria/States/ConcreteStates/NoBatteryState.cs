﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeBateria.States;

namespace GerenciamentoDeBateria.States.ConcreteStates
{
    internal class NoBatteryState : State
    {
        public NoBatteryState()
        {
            _battery = 0;
        }

        public override void ClickOnOffButton()
        {
            ColoredText("\t[ SEM BATERIA ]\n");
            Console.WriteLine("Conecte o carregador antes de usar!");
            return;
        }

        public override void PutCharger()
        {
            ColoredText("\t[ SEM BATERIA ]\n");
            Console.WriteLine("Carregador conectado, vou carregar...");
            _notebook.TransitionTo(new ChargingState(_battery));
        }

        public override void RemoveCharger()
        {
            ColoredText("\t[ SEM BATERIA ]\n");
            Console.WriteLine("Não estou sendo carregado!");
            return;
        }

        public override void CheckBattery()
        {
            ColoredText("\t[ SEM BATERIA ]\n");
            Console.WriteLine($"Porcentagem de bateria: {_battery}%");
            return;
        }

        public override void PrintStateName()
        {
            ColoredText("\t[ SEM BATERIA ]\n");
        }

        private void ColoredText(string text)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
