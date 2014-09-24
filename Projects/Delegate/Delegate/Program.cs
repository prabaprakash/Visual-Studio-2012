using System;

public delegate void addFunctionDelegate(string a);

public delegate void dadFunctionDelegate(string a);
class Program
    {
       public static void Main()
    {
        addFunctionDelegate dd = new addFunctionDelegate(add);
        dd("dai");
        dadFunctionDelegate d = new dadFunctionDelegate(add);
        d("daid");
        Console.ReadLine();
        }

     
       public static void add(string a)
       {
           Console.WriteLine(a);
           
       }

       public static void dad(string d)
       {
           Console.WriteLine(d);
           Console.ReadLine();
       }
       
    }
