using SimpleSolidVitasCarCalculator.CalculatorPrinters;

namespace CarCalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void DummyPrinter_PrintOnce_EverythingOK()
        {
            // Arrange
            var dummyPrinter = new DummyPrinter();

            // Act
            dummyPrinter.Print("Hello world!");

            // Assert
            Assert.True(true);
        }


        [Fact]
        public void DummyPrinter_PrintFour_Failure()
        {
            // Arrange
            var dummyPrinter = new DummyPrinter();

            // Act, print 3x
            dummyPrinter.Print("Hello world!");
            dummyPrinter.Print("Hello world!");
            dummyPrinter.Print("Hello world!");

            // Assert, print another
            Assert.Throws<Exception>(() => dummyPrinter.Print("Hello world!"));
        }
    }
}