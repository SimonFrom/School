using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    public class Menu
    {
        public string Title = "";
        public string[] MenuItem = new string[10];
        public int ItemCount = 0;

        public MenuItem[] MenuItems;
        public string Show(string title)
        {
            Console.WriteLine(Title);
            return Title;
        }
    }
}
