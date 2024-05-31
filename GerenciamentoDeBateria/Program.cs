using GerenciamentoDeBateria.Context;
using GerenciamentoDeBateria.States.ConcreteStates;

namespace GerenciamentoDeBateria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Execute();
        }

        static void Execute()
        {
            Notebook notebook = new Notebook(new OffState(100));
            ConsoleKey key = ConsoleKey.NumPad0; //atribuindo tecla aleatoria para a primeira execução;
            bool correctKey = true;

            do
            {
                Console.Clear();

                Console.WriteLine(">>>>>Estado da Bateria do Notebook<<<<<\n");
                switch (key)
                {
                    case ConsoleKey.D1:
                        notebook.ClickOnOffButton();
                        break;
                    case ConsoleKey.D2:
                        notebook.PutCharger();
                        break;
                    case ConsoleKey.D3:
                        notebook.RemoveCharger();
                        break;
                    case ConsoleKey.D4:
                        notebook.CheckBattery();
                        break;
                    default:
                        notebook.PrintStateName();
                        break;
                }

                Console.WriteLine("\n>>>>>Opções<<<<<");

                Console.WriteLine("1 - Clicar botão ON/OFF");
                Console.WriteLine("2 - Colocar carregador");
                Console.WriteLine("3 - Remover carregador");
                Console.WriteLine("4 - Checar bateria");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Any key - REFRESH");

                key = Console.ReadKey(true).Key;

            } while(key != ConsoleKey.D0);
        }
    }
}
