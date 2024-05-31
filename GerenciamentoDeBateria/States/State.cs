using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeBateria.Context;

namespace GerenciamentoDeBateria.States
{
    internal abstract class State
    {
        protected Notebook _notebook;
        protected int _battery;

        protected State()
        {

        }

        public void SetContext(Notebook notebook)
        {
            _notebook = notebook;
        }

        public abstract void ClickOnOffButton();

        public abstract void PutCharger();

        public abstract void RemoveCharger();

        public abstract void CheckBattery();

        public abstract void PrintStateName();
    }
}
