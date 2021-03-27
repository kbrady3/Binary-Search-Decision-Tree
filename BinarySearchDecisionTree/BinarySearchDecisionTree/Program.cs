using BinaryPrintDecisionsDecisionTree;
using System;

namespace BinarySearchDecisionTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node();

            Console.WriteLine("Having trouble deciding what kind of dessert to have? You've come to the right place!");
            Console.WriteLine("Do you want a 'hot' or 'cold' dessert?");
            string hotCold = Console.ReadLine().ToLower();
            n.DeterminePosition(hotCold);
            
            if (hotCold.Equals("hot"))
            {
                Console.WriteLine("Do you want 'cake' or 'cookies'?");
                string cakeCookies = Console.ReadLine().ToLower();
                n.DeterminePosition(cakeCookies);

                if (cakeCookies.Equals("cake"))
                {
                    Console.WriteLine("'White' or 'chocolate'?");
                    string whiteChocolate = Console.ReadLine().ToLower();
                    n.DeterminePosition(whiteChocolate);
                }
                else if (cakeCookies.Equals("cookies"))
                {
                    Console.WriteLine("'Sugarcookie' or 'chocolate chip'?");
                    string sugarCookieChocolate = Console.ReadLine().ToLower();
                    n.DeterminePosition(sugarCookieChocolate);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (hotCold.Equals("cold"))
            {
                Console.WriteLine("Do you want 'ice cream' or 'cheesecake'?");
                string iceCreamCheesecake = Console.ReadLine().ToLower();
                n.DeterminePosition(iceCreamCheesecake);

                if (iceCreamCheesecake.Equals("ice cream"))
                {
                    Console.WriteLine("'Choc' or 'vanilla'?");
                    string chocVanilla = Console.ReadLine().ToLower();
                    n.DeterminePosition(chocVanilla);
                }
                else if (iceCreamCheesecake.Equals("cheesecake"))
                {
                    Console.WriteLine("'Strawberry' or 'cookies and cream'?");
                    string strawberryCream = Console.ReadLine().ToLower();
                    n.DeterminePosition(strawberryCream);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Congrats! You've made a decision!");
            //NOTE: Use PrintDecisions() to traverse tree.
        }
    }
}
