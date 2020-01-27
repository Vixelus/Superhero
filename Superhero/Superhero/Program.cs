using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            Fire f1 = new Fire();
            Ice i1 = new Ice();

            Console.WriteLine("Hello and welcome to the superhero game!!");
            Console.WriteLine("In this game you will be able to chose between 2 classes, the Fire Mage or the Ice Witch");
            Console.WriteLine("begin by choosing a class");
           
 
            string[] menu = { "Fire", "Ice" };// start menu ,an array with options the player can choose from
            int selected = 0;
            while (true)
            {

                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == selected) Console.Write(">");
                    else Console.Write(" ");
                    Console.WriteLine(menu[i]);
                }


                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) selected--;
                if (key.Key == ConsoleKey.DownArrow) selected++;
                if (key.Key == ConsoleKey.Enter) break;

                Console.Clear();
                if (selected > menu.Length - 1)
                {
                    selected = menu.Length - 1;
                }

                if (selected < 0)
                {
                    selected = 0;
                }

            }
            if (selected == 0 ) //Allows the player to select to play as the fire class.
            {
                f1.Name();
                f1.Origin();
                f1.fire();
                f1.Hurt(-50);
            }
            if (selected == 1) //Allows the player to select to play as the ice class.
            {
                i1.Name();
                i1.Origin();
                i1.ice();
                i1.Hurt(-40);
            }
            Console.ReadLine();
        }
    }
}
