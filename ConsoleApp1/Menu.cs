using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Menu
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public List<Menu> menus { get; set; }
    }
}
