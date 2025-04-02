using System.Collections;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();
    public string Name { get; set; }
    public void AssignTable(Table table)
    {
        assignedTables.Add(true);
    }

    public void TakeOrder(Table table, Dish dish)
    {
        if (assignedTables.Contains(table))
        {
            table.AddToOrder(dish);
        }
        else
        {
            Console.WriteLine("esta mesa no esta asignada al mozo");
        }
    }
}