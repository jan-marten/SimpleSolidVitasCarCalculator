namespace SimpleSolidVitasCarCalculator.Calculators
{
    public class ElectricCarCalculator
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;


        public double CalculatePrice(double carPrice, double taxRate, double discount = 0)
        {
            return carPrice * (1 + taxRate) * (1 - discount);
        }

        public void PrintReceipt(string customerName, double carPrice, double taxRate, double discount = 0)
        {
            // BUG: John from the sales department has customers complaining that receipts for electric cars are not printed correctly.

            var calculatedPrice = CalculatePrice(carPrice, taxRate, discount);
            Console.WriteLine(
                  $"Customer: {customerName} bought a {Brand} {Model} with {FuelType} engine. \r\n"
                + $"Total price € {carPrice}. \r\n"
                + "Thanks for your purchase at Vitas Car Company.");
        }

    }
}
