using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    class Ice : Character
    {
        
        int dmg = 40;
        public void ice()
        {
            Console.WriteLine("A challenger aproches be ready to cast your spell!!");

            string[] menu = { "Ice Spike", "Frost wall" };// start menu ,an array with options the player can choose from
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
            if (selected == 0) //Allows the player to select what spell they want to shoot.
            {
               //you chose to cast the ice spike on your opponent.
            }
            if (selected == 1)//Allows the player to select what spell they want to shoot.
            {
               //you chose to cast the frost wall on your opponent.
            }
            Console.WriteLine("You did " + dmg + " to your opponent");
        }
    }
}
