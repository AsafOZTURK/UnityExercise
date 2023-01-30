using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    class Book
    {
        public static List<People> personList = new List<People>();
        
        
        public Book()
        {
            People person1 = new People { Name = "Ahmet",    Surname = "xx",   Phone = "05xxxxxxxxx" };
            People person2 = new People { Name = "Abdullah", Surname = "xx",   Phone = "05xxxxxxxxx" };
            People person3 = new People { Name = "Furkan",   Surname = "xx",  Phone = "05xxxxxxxxx" };
            People person4 = new People { Name = "Berat",    Surname = "xx",  Phone = "05xxxxxxxxx" };
            People person5 = new People { Name = "Ali",      Surname = "xx", Phone = "05xxxxxxxxx" };

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);
        }


        
    }
}