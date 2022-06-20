using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            //MAKE Menu start
            Menu MainMenu = new Menu() { Title = "MainMenu" ,menus = new List<Menu>() };
            Menu Home = new Menu() { Title = "Home" ,menus = new List<Menu>() };
            Menu Features = new Menu() { Title = "Features" ,menus = new List<Menu>() };
            Menu Feature1 = new Menu() { Title = "feature1" ,menus = new List<Menu>() };
            Menu Feature11 = new Menu() { Title = "feature11" ,menus = new List<Menu>() };

            Menu Feature12 = new Menu() { Title = "feature12" ,menus = new List<Menu>() };
            Menu Feature2 = new Menu() { Title = "feature2" ,menus = new List<Menu>() };
            Menu Feature3 = new Menu() { Title = "feature3" ,menus = new List<Menu>() };
            Menu Feature4 = new Menu() { Title = "feature4" ,menus = new List<Menu>() };
            Menu Feature41 = new Menu() { Title = "feature41" ,menus = new List<Menu>() };
            Menu Feature411 = new Menu() { Title = "feature411" ,menus = new List<Menu>() };

            Menu SubHome = new Menu() { Title = "subHome" ,menus = new List<Menu>() };

            MainMenu.menus.Add(Home);
            MainMenu.menus.Add(Features);
            Home.menus.Add(SubHome);
            Features.menus.Add(Feature1);
            Features.menus.Add(Feature2);
            Features.menus.Add(Feature3);
            Features.menus.Add(Feature4);


            Feature1.menus.Add(Feature11);
            Feature1.menus.Add(Feature12);
            Feature4.menus.Add(Feature41);
            Feature41.menus.Add(Feature411);

            //MAKE Menu End

            //Draw Menu
            MenuHelper menuHelper = new MenuHelper();
            menuHelper.Draw(MainMenu ,0);






        }
    }
}
