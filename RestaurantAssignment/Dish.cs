using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssignment;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Catagory Catagory { get; set; }
    public Dish(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    public  Dish[] FindDishesCategory(Catagory catagory, Dish[] dishes)
    {
       Dish[] filteredDishes = new Dish[dishes.Length];
        for (int i = 0,j=0; i < dishes.Length; i++)
        {
            if (dishes[i].Catagory == catagory)
            {
                filteredDishes[i] = dishes[i];
                j++;
            }

        }
        return filteredDishes;
    }


}
