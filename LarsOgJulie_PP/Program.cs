
using LarsOgJulie_PP;

Console.WriteLine("Butikk-oversikts-appen!\n" +
    "Se oversikt over butikker og prisklasser, eller legg til en ny butikk.\n" +
    "[1] Se oversikt over alle butikker og prisklasser.\n" +
    "[2] Legg til en ny butikk.\n" +
    "[3] Søk etter prisklasser.");

List<Shop> shops = new List<Shop>()
{
    new("IKEA", "Møbler", 1),
    new("Bohus", "Møbler", 2),
    new("Italian Design & Interior", "Møbler", 3),
    new("New Yorker", "Klær", 1),
    new("Dressmann", "Klær", 2),
    new("Hugo Boss", "Klær", 3),
    new("TGR", "Greier",1),
    new("Normal", "Greier", 2),
    new("Clas Ohlson", "Greier", 3)
};



while (true)
{
    string menuChoices = Console.ReadLine();

    switch (menuChoices)
    {
        case "1":
            PrintShopList();
            break;
        case "2":
            AddNewShop();
            break;
        case "3":
            SearchByPrice();
            break;
        case "0":
            Console.WriteLine("Takk for handelen. Håper lommeboken overlevde.");
            return;
        default:
            Console.WriteLine("Feil tastevalg. Prøv på nytt.");
        break;
    }
}

void PrintShopList()
{
    foreach(Shop shop in shops)
    {
        shop.PrintInfo();
    }
}

void AddNewShop()
{
    Console.WriteLine("Hva heter butikken?");
    var shopName = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Hva slags butikk er det? 'Klær', 'Møbler' eller 'Greier'?");
    var shopType = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Hvor dyrt er det? '1' = billig, '2' = middels og '3' = dyrt.");
    var shopPrice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Shop shop = new Shop(shopName, shopType, shopPrice);
    shops.Add(shop);

    Thread.Sleep(700);
    Console.WriteLine($"{shopName} ble lagt til i butikklisten!");
}

void SearchByPrice()
{
    Console.WriteLine("Hvilken prisklasse ønsker du å se butikker av?\n" +
        "1 = Billig\n" +
        "2 = Middels\n" +
        "3 = Dyrt");
    var userInput = Convert.ToInt32(Console.ReadLine());
    foreach (Shop shop in shops)
    {
        if (userInput == shop._shopPrice)
        {
            shop.PrintInfo();
            //Console.WriteLine($"Navn: {shop._shopName}\nType: {shop._shopType}\nPris: {shop._shopPrice}");
        }
    }
}