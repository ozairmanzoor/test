namespace PrimeService.Tests;

public class PrinterTest
{
    [Fact]
    public void Print_Test()
    {
        var printer = new Printer();
        printer.Print("hello");
    }
}