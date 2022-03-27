using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMLibrary.Models
{
    public class customer
    {
        public string customerCode { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string adress { get; set; }
        public string Zip { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }

        public string fullName { get { return name.PadRight(10) + surName.PadRight(10) + customerCode; } }
        public string orderShow { get { return name.PadRight(10) + surName.PadRight(10); } }
        
        //default constructor
        public customer()
        {

        }
        public customer(string customerCode, string name, string surName, string adresse, string Zip, string city, string phone, string mail)
        {
            this.customerCode = customerCode; 
            this.name = name;
            this.surName = surName;
            this.adress = adresse;
            this.Zip = Zip;
            this.city = city;
            this.phone = phone;
            this.mail = mail;
        }
    }
}
