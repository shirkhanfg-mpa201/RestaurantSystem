using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssignment;

public class Order
{

    public int Id { get; set; }
    public Dish[] dishes { get; set; }
    public decimal TotalAmount { get; set; }

    public Order(int id)
    {
        Id = id;
    }


}
