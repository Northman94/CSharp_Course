using System;
using System.Collections.Generic;

namespace S4E55_Dictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var people = new Dictionary<int, string>();

            people.Add(1, "Rachel Green");
            people.Add(2, "Monica Geller");
            people.Add(3, "Phoebe Buffay");


            // Another way:
            people = new Dictionary<int, string>()
            {
                {1, "Joey Tribbiani"},
                {2, "Chandler Bing"},
                {3, "Ross Geller"}
            };

            //It's not an index, it is a Key:
            string name = people[3];
            Console.WriteLine(name);


            var keyList1 = people.Keys;

            // If it wasn't var:
            //It's a Class folded in Dictionary.
            Dictionary<int, string>.KeyCollection keyList2 = people.Keys;

            foreach (var key in keyList2)
            {
                Console.WriteLine(key);
            }

            var values = people.Values;

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            // Iterating over Key/Value:
            // var here is: KeyValuePair<int, string> 
            foreach (var pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}");
            }


            Console.WriteLine($"Count = {people.Count}");


            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("Joey Tribbiani");

            Console.WriteLine($"Contains Key: {containsKey}. Contains Value: {containsValue}");

            //Delete Key/Value pair:
            people.Remove(1); //Removes bool


            //var t = people.TryAdd(5, "New Value"); //can be used as bool

            var е = people.TryGetValue(2, out string val0); //can be used as bool


            people.Clear();
        }
    }
}
