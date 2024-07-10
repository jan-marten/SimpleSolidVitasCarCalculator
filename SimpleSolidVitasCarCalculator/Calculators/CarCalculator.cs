namespace SimpleSolidVitasCarCalculator.Calculators
{
    public class CarCalculator
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;


        public double CalculatePrice(double carPrice, double taxRate)
        {
            return carPrice * (1 + taxRate);
        }

        public void PrintReceipt(string customerName, double carPrice, double taxRate)
        {
            var calculatedPrice = CalculatePrice(carPrice, taxRate);
            Console.WriteLine(
                  $"Customer: {customerName} bought a {Brand} {Model} with {FuelType} engine. \r\n"
                + $"Total price € {calculatedPrice}. \r\n"
                + "Thanks for your purchase at Vitas Car Company.");
        }

    }
}
