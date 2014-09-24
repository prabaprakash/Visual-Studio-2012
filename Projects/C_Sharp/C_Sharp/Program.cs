using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parta.Program;
public class praba
{

    public static void Main()
    {
        classa f = new classa();
        f.print();
        structa da = new structa { A = 2, B = 5 };
        da.printdetails();

        String[] s = new String[5];
        s[1] = "Praba";
        s[2] = "Sam";
        s[3] = "Mugesh";
        s[4] = "Praveen";
        s[0] = "Ram";
        Console.WriteLine(s[1]);
        foreach (String d in s)
        {
            Console.WriteLine(d);
        }

        Console.ReadLine();
    }
}
        
namespace parta
{
    namespace Program
    {
       public class classa
        {
            int a;
            int b;
          public  classa()
            {
                a = 5;
                b = 6;
            }
            public void print()
            {
                Console.WriteLine("A is.:" + a + "B is.:" + b);
            }
        }
       public struct structa
        {
            int a;
            int b;
            public int A
            {
                 get { return a; }
                set { a = value; }
            }
            public int B
            {
                get{return b;}
                set{b=value;}
            }
            public void printdetails()
            {
                Console.WriteLine("A is {0} B is {1}", a, b);
            }
       
        
        
        }


    }
}
