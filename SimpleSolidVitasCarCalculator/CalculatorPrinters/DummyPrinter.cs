namespace SimpleSolidVitasCarCalculator.CalculatorPrinters
{
    public class DummyPrinter : IPrinter
    {
        private int printCount = 0;

        public void Print(string message)
        {
            if (printCount > 2)
            {
                throw new Exception("Print count exceeded");

            }

            printCount++;

        }
    }
}
