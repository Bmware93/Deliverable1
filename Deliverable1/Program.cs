internal class Store
{
    private static void Main(string[] args)
    {
        int sodaCurrentStockValue = 100;
        int chipsCurrentStockValue = 40;
        int candyCurrentStockValue = 60;

        int sodaRestockMinimum = 40;
        int chipsRestockMinimum = 20;
        int candyRestockMinimum = 40;

        Console.WriteLine("Welcome to the Restocking tool");
        Console.WriteLine($"How many sodas have been sold today? {sodaCurrentStockValue} are currently in stock");

        int userInput = int.Parse(Console.ReadLine());

        var sodaRemainingStock = sodaCurrentStockValue - userInput;

        Console.WriteLine($"How many chips have been sold today? {chipsCurrentStockValue} are currently in stock");

        userInput = int.Parse(Console.ReadLine());
    }
}