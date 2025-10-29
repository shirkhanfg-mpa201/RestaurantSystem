using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssignment
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Dish[] Dishes { get; set; }

        public Catagory(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
