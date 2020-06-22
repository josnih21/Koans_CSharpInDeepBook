using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Write("Hola", null));
            //Console.WriteLine(WriteText());
            Console.WriteLine(WriteTuples());
        }

        //Nullable types
        static string Write(string x, string? y)
        {
            return x + "-------" + y;
        }

        //Anonymous types and implicit variables
        static string WriteText()
        {
            var book = new {Title = "Sueñan los androides con ovejas electricas", Author = "Phillip K. Dick"};
            string title = book.Title;
            string author = book.Author;
            return title + "    " + author;
        }

        /*
          different way to implement a variant for anonymous types with tuples
          can be used as parameter of return type from a method.   
         */
        static string WriteTuples()
        {
            var book = (title: "Sueñan los androides con ovejas electricas", author: "Phillip K Dick");
            string title = book.title;
            string author = book.author;
            return title + "    " + author;
        }
        
        
    }


}