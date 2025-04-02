using System.Diagnostics;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>

public class Dish
{
    public string name; 
    public double price;
    public bool isVegetarian;

    public Dish(string name, double price, bool isVegetarian)
    {
        this.name = name;
        this.price = price;
        this.isVegetarian = isVegetarian;
    }

    public string Name
    {
        get { return name; }
    }

    public double Price
    {
        get { return price; }
    }

    public bool IsVegetarian
    {
        get { return isVegetarian; }
    }
}

public class Program
{
    public static void Main()
    {
        Dish dish= new Dish("Hamburguesa", 850, false);
    }
}
