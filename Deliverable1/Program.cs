internal class Store
{
    private int sodaRemainingStock;
    private int chipsRemainingStock;
    private int candyRemainingStock;

    private int sodaRestockMinimum = 40;
    private int chipsRestockMinimum = 20;
    private int candyRestockMinimum = 40;

    public bool NoItemsNeedRestock =>
        sodaRemainingStock > sodaRestockMinimum &&
        chipsRemainingStock > chipsRestockMinimum &&
        candyRemainingStock > candyRestockMinimum;

    public static void Main(string[] args)
    {
        Store store = new Store();

        int sodaCurrentStockValue = 100;
        int chipsCurrentStockValue = 40;
        int candyCurrentStockValue = 60;

        Console.WriteLine("Welcome to the Restocking tool");
        Console.WriteLine("");

        //Asking user to input value of sodas sold
        Console.WriteLine($"How many sodas have been sold today? {sodaCurrentStockValue} are currently in stock.");

        int userInput = int.Parse(Console.ReadLine());

        //Checking for valid input from user
        //user cannot enter a value less than 0 or greater than whats in stock
        while (userInput > sodaCurrentStockValue || userInput < 0)
        {
            Console.WriteLine($"Sorry, that input is invalid. {sodaCurrentStockValue} are currently in stock.");
            userInput = int.Parse(Console.ReadLine());
        }
        //Once vaild input is received program calulate will display remaining soda stock back to user
        store.sodaRemainingStock = sodaCurrentStockValue - userInput;
        Console.WriteLine($"There are {store.sodaRemainingStock} sodas left in stock.");

        //Asking user to input value of chips sold
        Console.WriteLine($"How many chips have been sold today? {chipsCurrentStockValue} are currently in stock.");
        userInput = int.Parse(Console.ReadLine());

        //Checking for valid input from user
        //user cannot enter a value less than 0 or greater than whats in stock
        while (userInput > chipsCurrentStockValue || userInput < 0)
        {
            Console.WriteLine($"Sorry, that input is invalid. {chipsCurrentStockValue} are currently in stock.");
            userInput = int.Parse(Console.ReadLine());
        }
        //Once vaild input is received program calulate will display remaining chips stock back to user
        store.chipsRemainingStock = chipsCurrentStockValue - userInput;
        Console.WriteLine($"There are {store.chipsRemainingStock} chips left in stock.");

        //Asking user to input value of candy sold
        Console.WriteLine($"How much candy has been sold today? {candyCurrentStockValue} are currently in stock.");

        userInput = int.Parse(Console.ReadLine());

        while (userInput > candyCurrentStockValue || userInput < 0)
        {
            Console.WriteLine($"Sorry, that input is invalid. {candyCurrentStockValue} are currently in stock.");
            userInput = int.Parse(Console.ReadLine());
        }

        store.candyRemainingStock = candyCurrentStockValue - userInput;
        Console.WriteLine($"There are {store.candyRemainingStock} left in stock.");

        Console.WriteLine("");

        //Updating the user on what needs to be restocked
        if (store.NoItemsNeedRestock)
        {
            Console.WriteLine("Thank you for filling out those values. Nothing needs to be restocked at this time.");
        }
        else
        {
            Console.WriteLine("Thank you for filling out those values, here's what needs to be restocked: ");
            
            if (store.sodaRemainingStock <= store.sodaRestockMinimum)
            {
                Console.WriteLine("You need to restock on soda.");
            }
            if (store.chipsRemainingStock <= store.chipsRestockMinimum)
            {
                Console.WriteLine("You need to restock on Chips.");
            }
            if (store.candyRemainingStock <= store.candyRestockMinimum)
            {
                Console.WriteLine("You need to restock on candy.");
            }
        }
        Console.ReadLine();
    }
}