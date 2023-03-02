using System;
using System.Collections;

ArrayList a= new ArrayList();
a.Add("Hello");
a.Add("bye");
a.Add("Welcome");

Console.WriteLine(a[1]);

foreach(String item in a)
{
    Console.WriteLine(item);

}

Console.WriteLine(a.Contains("Welcome"));
Console.WriteLine("after sorting");
a.Sort();
foreach (String item in a)
{
    Console.WriteLine(item);

}

