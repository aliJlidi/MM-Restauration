using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMLibrary.Models;

namespace MMLibrary
{
    public class sqliteDataAccess: IDataConnection
    {
        public  List<Users> LoadUsers()
        {
            //open the connection and close when done , never leave connection open
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Users>("select * from Users", new DynamicParameters());
                return output.ToList();
            }
        }
        public  void SaveUsers(Users user)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into Users (user, password) values (@user, @password)", user);
            }

        }


        public  List<customer> customer_GetAll()
        {
            List<customer> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<customer>("SELECT * FROM customer").ToList();
            }
            return output;
        }

        public  void customer_Create(customer cstm)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into customer (customerCode, name, surName, adress, Zip, city, phone, mail) values(@customerCode, @name, @surName, @adress, @Zip, @city, @phone, @mail) ", cstm);
            }
        }

        public void customer_Edit(customer cstm)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("update customer set  name=@name, surName=@surName, adress=@adress, Zip=@Zip, city=@city, phone=@phone, mail=@mail   where customerCode = @customerCode", cstm);
            }
        }

        public void customer_Delete(customer cstm)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("delete from customer where customerCode = @customerCode", new {customerCode = cstm.customerCode});
            }
        }

        public List<Models.food> food_GetAll()
        {
            List<food> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food").ToList();
            }
            return output;
        }

        public void food_Create(food fd)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into food (foodCode, name, category, price) values(@foodCode, @name, @category, @price)", fd);
            }
        }

        public void food_Edit(food fd)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("update food set  name=@name, category=@category, price=@price where foodCode = @foodCode", fd);
            }
        }

        public void food_Delete(food fd)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("delete from food where foodCode = @foodCode", new { foodCode = fd.foodCode });
            }
        }
    }
}
