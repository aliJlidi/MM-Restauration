using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMLibrary.Models
{
    public class food
    {
        public string foodCode { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string price { get; set; }
        public string foodName { get { return category.PadRight(10)  + name.PadRight(20) + price + "€"; } }


        public food()
        {

        }

        public food(string foodCode, string name, string category, string price)
        {
            this.foodCode = foodCode;
            this.name = name;
            this.category = category;
            this.price = price;
        }
    }
}
