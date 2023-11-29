using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace firstLinq
{
    internal class Program
    {
        static void Main(string[] args)
            //Goal : Compare between using linq (query expression and methode expression)
        {
            //Creat a list of string
            List<string> names = new List<string>()
            { 
            
                "red","book","car","computer","mobile",
            
            };
                        //  Query expression

            //var result=from item in names where item.Length > 3 
            //          select item;
                        
                        //Methode expression
            var result = names.Where(item => item.Length > 3);


                        //traditional code
            /* List<string> result = new List<string>();
             for (int i= 0; i < names.Count;i++) 
             {
                 if (names[i].Length>3) {
                     result.Add(names[i]);
                 }
             }
            */

                            //Print the result
            foreach (string name in result) {
            Console.WriteLine(name);

             }

             
        }
    }
}