using System;




String[] a1 = new String[2];
a1[0] = "Hello";
a1[1] = "Bye";
Console.WriteLine(a1[1]);

for (int i = 0; i < a1.Length; i++)
{
    Console.WriteLine(a1[i]);
    if (a1[i])== "Hello"
    {
        Console.WriteLine("match found");
        break;
    }

}


