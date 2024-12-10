using DemoLister;

List<Item> Items = new List<Item>()
    {
        new Item("Lightbulb", "Electronics", 10),
        new Item("Lighter", "Personal", 12),
        new Item("Apple", "Food", 3),
        new Item("Diaper", "Baby", 60)
    };
PrintList();

void PrintList()
{
    foreach (var item in Items)
    {
        Console.WriteLine(item.getName());
    }

    for (int i = 0; i < Items.Count; i++)
    {
        Console.WriteLine($"{i}. {Items[i].getName()}");
    }

    Console.WriteLine("full info");
    int input = int.Parse(Console.ReadLine());

    Console.WriteLine($"{Items[input].getName()} {Items[input].getPrice()}");
    Console.WriteLine("new Price");
    int newPrice = int.Parse(Console.ReadLine());
    Items[input].setPrice(newPrice);
    Console.WriteLine($"{Items[input].getName()} {Items[input].getPrice()}");
}
   