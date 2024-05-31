using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeBateria
{
    internal class Notebook
    {
        private State _state;

        public Notebook(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Alterando estado para: [ {state.GetType().Name.ToUpper()} ]");
            this._state = state;
            this._state.SetContext(this);
        }

        public  void ClickOnOffButton()
        {
            this._state.ClickOnOffButton();
        }

        public  void PutCharger()
        {
            this._state.PutCharger();
        }

        public  void RemoveCharger()
        {
            this._state.RemoveCharger();
        }

        public void CheckBattery()
        {
            this._state.CheckBattery();
        }

        public void PrintStateName()
        {
            this._state.PrintStateName();
        }
    }
}
