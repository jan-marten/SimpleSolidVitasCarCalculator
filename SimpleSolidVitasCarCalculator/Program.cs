using SimpleSolidVitasCarCalculator.Calculators;

Console.WriteLine("Vitas Car Company - TERMINAL");

var customerName = ReadLine.Read("Enter Customer name (Customer1):", "Customer1");

var carBrand = ReadLine.Read("Enter Car Brand (Opel):", "Opel");

var carModel = ReadLine.Read("Enter Car Model (Astra):", "Astra");

var carFuelType = ReadLine.Read("Enter Car Fuel Type (Euro95):", "Euro95");

var carPriceInput = ReadLine.Read("Enter Car Price (€ 30.000 or enter value):", "30000");
if (double.TryParse(carPriceInput, out double carPrice) == false)
{
    carPrice = 30000;
}


// Opdracht 1: Pas onderstaande code aan zodat je 1 calculator overhoudt die beide soorten auto's kan berekenen.
// Hiermee voorkom je duplicatie van code = beter onderhoudbaar.

if (carFuelType.ToLower().Contains("electric"))
{
    var electricCarCalculator = new ElectricCarCalculator();
    electricCarCalculator.Brand = carBrand;
    electricCarCalculator.Model = carModel;
    electricCarCalculator.FuelType = carFuelType;
    electricCarCalculator.PrintReceipt(customerName, carPrice, 0.21);

    
    // Opdracht 2-a: Pas de printer code aan zodat je de calculator mee kunt sturen naar de printer.
    //var printer = new SimpleSolidVitasCarCalculator.CalculatorPrinters.TerminalPrinter();
    //printer.Print(electricCarCalculator.PrintReceipt(customerName, carPrice, 0.21));
}
else
{
    var carCalculator = new CarCalculator();
    carCalculator.Brand = carBrand;
    carCalculator.Model = carModel;
    carCalculator.FuelType = carFuelType;
    carCalculator.PrintReceipt(customerName, carPrice, 0.21);

    //var printer = new SimpleSolidVitasCarCalculator.CalculatorPrinters.TerminalPrinter();
    //printer.Print(carCalculator.PrintReceipt(customerName, carPrice, 0.21));
}

// Opdracht 2-b; Nog een printer toevoegen die naar e-mail toeprint.
Console.WriteLine("Do you want to send the receipt to your E-Mail? (Y/N):");
var sendReceiptToEmail = Console.ReadLine() ?? "N";
if (sendReceiptToEmail.ToLower() == "y")
{
    Console.WriteLine("Enter your E-Mail address:");
    var emailAddress = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(emailAddress) == false)
    {
        var emailer = new SimpleSolidVitasCarCalculator.CalculatorPrinters.EmailPrinter();
        emailer.Print("...");

        Console.WriteLine($"Receipt sent to {emailAddress}");
    }
}

Console.WriteLine("THE END.");
