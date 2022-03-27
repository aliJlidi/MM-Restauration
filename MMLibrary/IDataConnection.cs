using MMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMLibrary
{
   public interface IDataConnection
    {
        // read customers
        List<customer> customer_GetAll();
        // create customer
        void customer_Create(customer cstm);
        // edit customer
        void customer_Edit(customer cstm);
        // delete customer 
        void customer_Delete(customer cstm);

        // read Foods 
        List<food> food_GetAll();
        // create Food 
        void food_Create(food fd);
        // edit Food 
        void food_Edit(food fd);
        // Delete Food
        void food_Delete(food fd);
        // create Order (Optional)
    }
}
