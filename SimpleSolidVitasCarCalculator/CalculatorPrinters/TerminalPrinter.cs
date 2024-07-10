namespace SimpleSolidVitasCarCalculator.CalculatorPrinters
{
    public class TerminalPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
