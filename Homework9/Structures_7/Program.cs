using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете пет карти");
            string[] card = new string[5]; int i = 0;
            do
            {
                card[i] = Console.ReadLine();
                if (card[i] == "J" || card[i] == "Q" || card[i] == "K" || card[i] == "A" ||
                    card[i] == "10" || (Convert.ToChar(card[i]) > '1' && Convert.ToChar(card[i]) <= '9'))
                {
                    i++;
                }else
                {
                    Console.WriteLine("Не съществува подобна карта,въведете отново");
                }
            } while (i < 5);
            int counter = 0;
            for (int j = 0; j < card.Length; j++)
            {
                counter = 0;
                if (card[j] == Convert.ToString(true))
                {
                    continue;
                }
                for (int k = 0; k < card.Length; k++)
                {
                    if (card[j] == card[k])
                    {
                        if (j != k)
                        {
                            card[k] = Convert.ToString(true);
                        }
                        counter++;
                    }
                }
                switch (counter)
                {
                    case 2: Console.WriteLine("Чифт: {0}", card[j]); continue;
                    case 3: Console.WriteLine("Сет: {0}", card[j]); continue;
                    case 4: Console.WriteLine("Каре: {0}", card[j]); break;
                    case 5: Console.WriteLine("Пич , тестето ти е неадекватно"); break;
                }
            }
        }
    }
}
