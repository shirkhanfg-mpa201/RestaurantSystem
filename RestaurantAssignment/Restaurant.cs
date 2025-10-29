using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssignment;

public class Restaurant
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Order[] Orders { get; set; }
    public Dish[] Menu { get; set; }

    public Restaurant(string name)
    {
        Name = name;
        Menu = new Dish[0];     
        Orders = new Order[0];
    }

    public void AddDishToMenu(Dish dish)
    {
        Dish[] newMenu = new Dish[Menu.Length + 1];
        for (int i = 0; i < Menu.Length; i++)
        {
            newMenu[i] = Menu[i];
        }
        newMenu[Menu.Length] = dish;
        Menu = newMenu;
    }

    public void PlaceOrder(Order order)
    {
        Order[] newOrders = new Order[Orders.Length + 1];
        for (int i = 0; i < Orders.Length; i++)
        {
            newOrders[i] = Orders[i];
        }
        newOrders[Orders.Length] = order;
        Orders = newOrders;
    }
    public Order GetOrderById(int id)
    {
        for (int i = 0; i < Orders.Length; i++)
        {
            if (Orders[i].Id == id)
                return Orders[i];
        }
        return null; 
    }

}
