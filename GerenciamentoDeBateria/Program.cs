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
                    case ConsoleKey.A:
                        notebook.ClickOnOffButton();
                        break;
                    case ConsoleKey.D:
                        notebook.PutCharger();
                        break;
                    case ConsoleKey.G:
                        notebook.RemoveCharger();
                        break;
                    case ConsoleKey.J:
                        notebook.CheckBattery();
                        break;
                    default:
                        notebook.PrintStateName();
                        break;
                }

                Console.WriteLine("\n>>>>>Opções<<<<<");

                Console.WriteLine("A - Clicar botão ON/OFF");
                Console.WriteLine("D - Colocar carregador");
                Console.WriteLine("G - Remover carregador");
                Console.WriteLine("J - Checar bateria");
                Console.WriteLine("ESC - Sair");

                key = Console.ReadKey(true).Key;

            } while(key != ConsoleKey.Escape);
        }
    }
}
