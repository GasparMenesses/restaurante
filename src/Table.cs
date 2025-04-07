namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    
    public string Number { get; set; }
        
    public bool IsOccupied { get; set; }
    
    private ArrayList order = new ArrayList();

    public void Ocuppy()
    {
        IsOccupied = true;
    }
    
    public void Free()
    {
        IsOccupied = false;
        order.Clear();  
    }

    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}
