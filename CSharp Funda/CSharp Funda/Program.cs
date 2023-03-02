using System;

namespace CSharp_Funda
{
    class Program : Program4
    {
        string name;
        public Program(String name)
        {
            //constructor is used to initial the variables
            this.name = name;

        }
        public void getName()
        {
            Console.WriteLine("my name is " +  this.name);//this operator is used to refers to the current class.
        }
        public void getData()
        {
            // methods cannot go inside the main block
            Console.WriteLine("iam inside method");

        }
        static void Main(string[] args)
        {
            Program p = new Program("kanna");
            p.getData();
            p.SetData();
            p.getName();

            Console.WriteLine("Hello World!");
            int a = 4;
            Console.WriteLine("number is " + a);

            String name = "Deepu";
            Console.WriteLine("name is " + name);
           

            var age = 23;
            Console.WriteLine("age is " + age);

            dynamic height = 13.21;
            Console.WriteLine("height is " + height);

            height = "hello";
            Console.WriteLine("height is " + height);


        }
    }

}
