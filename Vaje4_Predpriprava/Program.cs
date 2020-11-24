using System;
using System.Collections.Generic;

namespace Vaje4_Predpriprava
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating HashSet 
            // Using HashSet class 
            HashSet<string> seznam1 = new HashSet<string> { "Test1", "Test2", "Test3"};

            // Add the elements in HashSet 
            // Using Add method 
            seznam1.Add("Marko");
            seznam1.Add("Primoz");
            seznam1.Add("Zak");
            seznam1.Add("Pak");
            seznam1.Add("Mak");
             
            // Creating another HashSet 
            // Using HashSet class 
            HashSet<string> seznam2 = new HashSet<string>();
            // Add the elements in HashSet 
            // Using Add method 
            seznam2.Add("Matej");
            seznam2.Add("Ivan");
            seznam2.Add("Lan");
            seznam2.Add("Marko");
            seznam2.Add("Jaka");
            seznam2.Add("Mak");

            // Creating a new HashSet that contains 
            // the union of both the HashSet mySet1 & mySet2 
            HashSet<string> seznamUnija= new HashSet<string>(seznam1);
            seznamUnija.UnionWith(seznam2);

            izpisSeznam(seznam1, "Seznam1");
            izpisSeznam(seznam2, "Seznam2");
            izpisSeznam(seznamUnija, "Unija");

            // Using IntersectWith method 
            HashSet<string> seznamPresek = new HashSet<string>(seznam1);
            seznamPresek.IntersectWith(seznam2);
            izpisSeznam(seznamPresek, "Presek");

            // After using Remove method 
            Console.WriteLine("Total number of elements present" +
                                " in myhash: {0}", seznam1.Count);


            // Remove element from HashSet 
            // Using Remove method 
            seznam1.Remove("Ruby");

            // Before using Remove method 
            Console.WriteLine("Total number of elements present" +
                                " in myhash: {0}", seznam1.Count);

            // Remove all elements from HashSet 
            // Using Clear method 
            seznam1.Clear();
            Console.WriteLine("Total number of elements present" +
                                 " in myhash:{0}", seznam1.Count);



        }

        static void izpisSeznam(HashSet<String> pseznam, string naziv)
        {

            Console.WriteLine(naziv);
            foreach (var ele in pseznam)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
