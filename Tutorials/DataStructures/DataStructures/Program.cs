using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an instance of each generic collection classes
            List<string> princesses = new List<string>();
            LinkedList<string> moviesThatMadeMeCry = new LinkedList<string>();
            Queue<string> resturantOrders = new Queue<string>();
            Stack<string> dishesToWash = new Stack<string>();
            Dictionary<string, string> codeNames = new Dictionary<string, string>();
            SortedList<string, double> resturantRatings = new SortedList<string, double>();
            HashSet<string> justiceLeague = new HashSet<string>();
            HashSet<string> heroesThatFly = new HashSet<string>();

            // Insert 5 values into each collection, iterate over the collection and print each value to console
            // Print a line above your iteration stating which data structure you're printing from and a blank line between each collection
            
            // List
            Console.WriteLine("List data structure - Disney Princessess:");

            foreach (string princess in new string[5] { "Jasmine", "Cinderella", "Snow White", "Rapunzel", "Lilo" })
            {
                princesses.Add(princess);
            }

            for (int i = 0; i < princesses.Count; i++)
            {
                string princess = princesses[i];
                Console.WriteLine(princess);
            }

            Console.WriteLine();

            // Linked List
            Console.WriteLine("Linked list data structure - Movies that made me cry:");

            foreach (string movie in new string[5] { "Up", "Lion King", "Coco", "Toy Story", "Tangled"} )
            {
                moviesThatMadeMeCry.AddFirst(movie);
            }

            for (LinkedListNode<string> node = moviesThatMadeMeCry.First; node != null; node = node.Next)
            {
                string movie = node.Value;
                Console.WriteLine(movie);
            }

            Console.WriteLine();

            // Queue

            Console.WriteLine("Queue data structure - Resturant Orders:");

            foreach(string order in new string[5] { "Tacos", "Bacon Cheese Burger", "Fried Chicken", "Meat-Lovers Pizza", "Nachoes"})
            {
                resturantOrders.Enqueue(order);
            }

            foreach(string order in resturantOrders)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine();

            // Stack
            Console.WriteLine("Stack data structure - Dishes to wash:");

            foreach (string dish in new string[5] { "Plate", "Bowl", "Plate", "Spoon", "Bowl"})
            {
                dishesToWash.Push(dish);
            }
            
            foreach (string dish in dishesToWash)
            {
                Console.WriteLine(dish);
            }

            Console.WriteLine();

            // Dictionary
            Console.WriteLine("Dictionary data structure - Agent Code Names:");

            codeNames["Bruce Wayne"] = "Batman";
            codeNames["Steve Rogers"] = "Captain America";
            codeNames["David Bruce Banner"] = "Incredible Hulk";
            codeNames["Clark Kent"] = "Superman";
            codeNames["Barry Allen"] = "The Flash";

            foreach (var element in codeNames)
            {
                string name = element.Key;
                string code = element.Value;
                Console.WriteLine($"Name: {name}, Code Name: {code}");
            }

            Console.WriteLine();

            // Sorted List
            Console.WriteLine("Sorted list data structure - Resturant Ratings:");

            resturantRatings.Add("Nacho Business", 3.5);
            resturantRatings.Add("Tequila Mockingbird", 4.0);
            resturantRatings.Add("Not Another Buger Place", 4.5);
            resturantRatings.Add("Thai Tanic", 4.0);
            resturantRatings.Add("Frying Nemo", 5.0);

            foreach (KeyValuePair<string, double> element in resturantRatings)
            {
                string name = element.Key;
                double rating = element.Value;
                Console.WriteLine($"Name: {name}, Rating: {rating}");
            }

            Console.WriteLine();

            // Hash Set
            Console.WriteLine("Hash set data structure-");
            justiceLeague.Add("Superman");
            justiceLeague.Add("Batman");
            justiceLeague.Add("Wonder Woman");
            justiceLeague.Add("Cyborg");
            justiceLeague.Add("The Flash");

            heroesThatFly.Add("Superman");
            heroesThatFly.Add("Cyborg");
            heroesThatFly.Add("Green Lantern");
            heroesThatFly.Add("Shazam");
            heroesThatFly.Add("Storm");

            Console.WriteLine("Justice League Members (Snyder's Cut):");

            foreach (string hero in justiceLeague)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine();
            Console.WriteLine("Super Heroes that fly:");

            foreach (string hero in heroesThatFly)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine();
            Console.WriteLine("Justice League members that can fly:");

            justiceLeague.IntersectWith(heroesThatFly);
            foreach (string hero in justiceLeague)
            {
                Console.WriteLine(hero);
            }
        }
    }
}
