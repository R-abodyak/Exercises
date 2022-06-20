using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MenuHelper
    {
        public int Draw(Menu menu ,int pad)
        {

            Console.Write(menu.Title.PadLeft(pad));
            if( menu.menus.Count != 0 ) Console.WriteLine("=====>");

            foreach( var m in menu.menus )
            {


                if( m.menus.Count != 0 ) Draw(m ,pad + 5);

                if( m.menus.Count == 0 )
                    Console.WriteLine(m.Title.PadLeft(pad + 5));
            }
            return pad;

        }
    }
}
