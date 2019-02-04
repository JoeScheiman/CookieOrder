using System;
using System.Collections.Generic;

namespace CookieOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            
//Total the boxes purchased
//Show the list
//Remove a variety and give feedback on how many boxes were removed
//Show the updated list

            MasterOrder joeOrder = new MasterOrder();
            joeOrder.AddOrder("Peanutters", 5);
            joeOrder.AddOrder("Tag-a-Longs", 7);
            joeOrder.AddOrder("Peanutters", 6);
            joeOrder.AddOrder("Samoas", 2);

            Console.WriteLine("Total Boxes: " + joeOrder.totalBoxes);

            joeOrder.ShowOrder();

            Console.WriteLine("\n\nWe will now remove Peanutters");
            joeOrder.RemoveVariety("Peanutters");

            Console.WriteLine("New Total Boxes: " + joeOrder.totalBoxes);
            joeOrder.ShowOrder();



            Console.ReadLine();

        }
    }
    public class Cookie
    {
        public string Variety { set; get; }
   
        public int NumBoxes { set; get; }

        public Cookie(string s, int n)
        {
            Variety = s;
            NumBoxes = n;
        }
    }
    public class MasterOrder
    {
        public List<Cookie> Orders { get; set; }
        public int totalBoxes { get; set; }

        public MasterOrder()
        {
            totalBoxes = 0;
            Orders = new List<Cookie>();
        }

        public void AddOrder(string variety, int num)
        {
            
            Orders.Add(new Cookie(variety, num));
            totalBoxes += num;
        }
        public int GetTotalBoxes()
        {
            return totalBoxes;
        }
        public void RemoveVariety(string _variety)
        {
            int loopMax = Orders.Count;
            for (int i = 0; i < loopMax; i++)
            {
                if (Orders[i].Variety.Equals(_variety))
                {
                    Console.WriteLine("You are now removing " + Orders[i].NumBoxes + " of " + _variety);
                    totalBoxes -= Orders[i].NumBoxes;
                    Orders.RemoveAt(i);
                    i--;
                    loopMax--;
                }
            }
        }
        public int GetVarietyBoxes(string _variety)
        {
            int howMany = 0;
            int loopMax = Orders.Count;
            for (int i = 0; i < loopMax; i++)
            {
                if (Orders[i].Variety.Equals(_variety))
                {
                    howMany += Orders[i].NumBoxes;
                }
            }
            return (howMany);
        }
        public void ShowOrder()
        {
            Console.WriteLine("\tCurrent Order:");
            for (int i = 0; i < Orders.Count; i++)
                Console.WriteLine(i + " " + Orders[i].Variety + " \t" + Orders[i].NumBoxes);
        }
    }

}
