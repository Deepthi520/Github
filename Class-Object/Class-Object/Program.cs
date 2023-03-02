using Classes_Objects;
using System;

namespace Class_Object
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.pages);


            Console.ReadLine();
        }
    }
}
