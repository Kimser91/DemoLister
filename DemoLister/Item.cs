namespace DemoLister;

public class Item
{
    private string Name;
    private string Type;
    private int Price;

    public Item(string name, string type, int price)
    {
        Name = name;
        Type = type;
        Price = price;
    }

    public string getName()
    {
        return Name;
    }

    public int getPrice()
    {
        return Price;
    }

    public void setPrice(int input)
    {
        Price = input;
    }
}