using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    class Character
    {
        public string name;
        public int level = 1;
        public int hp = 100;
        

        public void Name()// you can name your hero
        {
            Console.WriteLine("We can start by naming your hero:");
            name = Console.ReadLine();
            Console.WriteLine("Your name is :" + name);
            Console.ReadKey();
                Console.Clear();

        }
        public void Origin()
        {
            Console.WriteLine("You can choose what origin you want your hero to be, please select:");
            string[] menu = { "Demacia", "Noxus" };// start menu ,an array with options the player can choose from
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
            if (selected == 0) //Allows the player to select what origin they are.
            {
                Console.WriteLine("You chose Demacia You get 30+ Defense");//you get stat boost.
            }
            if (selected == 1)//Allows the player to select what origin they are.
            {
                Console.WriteLine("You chose Noxus You get 30+ magic power"); //you get stat boost.
            }
        }
       


        public void Hurt (int damage)// this allows to do damage to your hero
        {
            hp -= damage;
            Console.WriteLine("You have "+ hp +" hp left");
        }

    }
}
