namespace SimpleSolidVitasCarCalculator.CalculatorPrinters
{
    public class EmailPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"Sending email");
            Thread.Sleep(2000);
            Console.WriteLine("Email sent successfully.");
        }
    }
}
