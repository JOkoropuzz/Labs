using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука", 823, 2013);
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();
            mag1.TakeItem();
            mag1.Show();
            mag1.IfSubs = true;
            mag1.Subs();

        }
    }
}
