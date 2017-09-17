using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestOpgaveCarLibrary
{
    public class Owner
    {
        //Properties
        public string Address { get; set; }       
        public string Name { get ; set; }
        public string Phone { get; set; }
        

        public string navneÆndring()
        {
            string navn = Name;
            if (Name.Length < 4)
            {
                throw new ArgumentException("navnet er for kort");
            }
            else return navn;
        }

        //Overloaded Constructor
        public Owner(string address, string name, string phone)
        {
            this.Address = address;
            this.Name = name;
            this.Phone = phone;
            

            if (address.Length < 6)
            {
                throw new ArgumentException("Addressen er for kort");
            }

            if (name.Length < 4)
            {
                throw new ArgumentException("Navnet er for kort");
            }

            if (phone.Length <= 7 || phone.Length >= 9)
            {
                throw new ArgumentException("Tlf Nummeret er enten for kort eller for langt");
            }

            navneÆndring();
        }
    }
}
