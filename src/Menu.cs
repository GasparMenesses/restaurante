namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList(); //Hace una lista
    public void AddDish(Dish dish)
    {
        dishes.Add(dish);
    }
    public void RemoveDish(Dish dish)
    {
        dishes.Remove(dish);
    }
    public Dish GetDishByName(string name)
    {
        foreach (Dish dish in dishes)
        {
            if (dish.name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return dish;
            }
        }
        return null;
    }
}
