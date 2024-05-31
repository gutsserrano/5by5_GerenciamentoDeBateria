using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeBateria.States;

namespace GerenciamentoDeBateria.Context
{
    internal class Notebook
    {
        private State _state;

        public Notebook(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Alterando estado para: [ {state.GetType().Name.ToUpper()} ]");
            _state = state;
            _state.SetContext(this);
        }

        public void ClickOnOffButton()
        {
            _state.ClickOnOffButton();
        }

        public void PutCharger()
        {
            _state.PutCharger();
        }

        public void RemoveCharger()
        {
            _state.RemoveCharger();
        }

        public void CheckBattery()
        {
            _state.CheckBattery();
        }

        public void PrintStateName()
        {
            _state.PrintStateName();
        }
    }
}
