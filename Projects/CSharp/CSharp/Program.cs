using System;

namespace CSharp
{
    public class Program
    {
        // Method 1

        //public  static void Main(string[] args)
        //  {
        //      Task<int> task = ComplexCalculationAsync();
        //      var awaiter = task.GetAwaiter();
        //      awaiter.OnCompleted(() => // Continuation
        //      {
        //          int result = awaiter.GetResult();
        //          Console.WriteLine(result); // 116
        //      });

        //      Console.WriteLine("gg");
        //      Console.ReadLine();
        //  }

        //  static Task<int> ComplexCalculationAsync()
        //  {
        //      return Task.Run(() =>
        //             {
        //                 double x = 2;
        //                 for (int i = 1; i < 100000000; i++)
        //                     x += Math.Sqrt(x) / i;
        //                 return (int)x;
        //             });
        //  }

        // Method 2

        //public static async void Main(string[] args)
        //{
        //    //Task<int> task = ComplexCalculationAsync();
        //    //var awaiter = task.GetAwaiter();
        //    //awaiter.OnCompleted(() => // Continuation
        //    //{
        //    int result = await ComplexCalculationAsync();
        //        Console.WriteLine(result); // 116
        //    //});
        //    Test();
        //    Console.WriteLine("gg");
        //    Console.ReadLine();
        //}
        //public static async void Test()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        int result = await ComplexCalculationAsync();
        //        Console.WriteLine(result);
        //    }
        //}
        //static Task<int> ComplexCalculationAsync()
        //{
        //    return Task.Run(() =>
        //    {
        //        double x = 2;
        //        for (int i = 1; i < 100000000; i++)
        //            x += Math.Sqrt(x) / i;
        //        return (int)x;
        //    });
        //}

        // Method 3

        //public static void Main(String[] args)
        //{
        // var it=GoingTo().GetAwaiter();

        //    it.OnCompleted(() => Console.WriteLine("hELLO"));
        // Console.WriteLine("Task Going");
        // Console.ReadLine();

        //}

        // public static async Task GoingTo()
        // {
        //     var ut = To().GetAwaiter();
        //     ut.OnCompleted(()=>Console.WriteLine("Go"));
        //     //await To();
        //     Console.WriteLine("GoingTo");
        // }
        // public static async Task To()
        // {
        //    // await Task.Delay(5000);
        //     Console.WriteLine((await KiloMeter()).ToString());

        // }

        // private static async Task<int> KiloMeter()
        // {
        //     await Task.Delay(6000);
        //     int c = 21*2;
        //     return (int) c;
        // }
        //Method 4 Delegates
        //    public static void Main()
        //    {
        //        var employees = new List<Employee>
        //            {
        //                new Employee
        //                    {
        //                        Id = 1,
        //                        Name = "sam",
        //                        Experience = 6,
        //                        Salary = 5000
        //                    },

        //                new Employee
        //                    {
        //                        Id = 1,
        //                        Name = "b",
        //                        Experience = 6,
        //                        Salary = 6
        //                    }
        //            };

        //    Employee.eEmployee(employees);
        //        Console.ReadLine();
        //    }

        //}

        //public delegate void deletes(Employee employee);

        //public class Employee
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public int Experience { get; set; }
        //    public int Salary { get; set; }

        //    public static void eEmployee(List<Employee> employees)
        //    {
        //        foreach (var employee in employees)
        //        {
        //           deletes nd=new deletes(checking);
        //            nd(employee);
        //        }
        //    }
        //    public static void checking(Employee employee)
        //    {
        //        if (employee.Experience > 5)
        //        {
        //            Console.WriteLine(employee.Name);
        //        }
        //    }
        //}
        //Method 6 Delegate in Class
        //public delegate bool DelegateChecking(CSharp.Employee employee);
        //public static void Main()
        //    {
        //        var employees = new List<Employee>
        //            {
        //                new Employee
        //                    {
        //                        Id = 1,
        //                        Name = "Sam",
        //                        Experience = 6,
        //                        Salary = 5000
        //                    },

        //                new Employee
        //                    {
        //                        Id = 1,
        //                        Name = "Praba",
        //                        Experience = 6,
        //                        Salary = 5000
        //                    }
        //            };
        //    DelegateChecking delegateChecking=new DelegateChecking(checkmethod);

        //    Employee.eEmployee(employees,delegateChecking);
        //        Console.ReadLine();
        //    }
        //    public static bool checkmethod(Employee employee)
        //    {
        //        if (employee.Experience>5)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        //public class Employee
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public int Experience { get; set; }
        //    public int Salary { get; set; }

        //    public static void eEmployee(List<CSharp.Employee> employees,Program.DelegateChecking checking)
        //    {
        //        foreach (var employee in employees)
        //        {
        //            if (checking(employee))
        //            {
        //                Console.WriteLine(employee.Name);
        //            }
        //        }
        //    }
        //Method 7 Generics
        // public static void Main(String[] args)
        // {
        //    bool e=Method<String,int>("a",2,2);
        //     if (e==true)
        //     {
        //         Console.WriteLine("a equal b");
        //     }
        //     else
        //     {
        //         Console.WriteLine("a not equals b");
        //     }
        //     Console.ReadLine();
        //   var f=  generic<int>.generi(1, 1);
        //     if (f == true)
        //     {
        //         Console.WriteLine("a equal b");
        //     }
        //     else
        //     {
        //         Console.WriteLine("a not equals b");
        //     }
        //     Console.ReadLine();
        // }
        //    public static bool Method<f,g>(f a, g b,g c)
        //    {
        //        return b.Equals(c);
        //    }
        //}
        //public class generic<g>
        //{
        //public static bool generi(g v1,g v2)
        //{
        //    return v1.Equals(v2);
        //}
        //Method 8 Enum
        public static void Main(String[] Args)
        {
            short[] f = (short[])Enum.GetValues(typeof(MyEnum));

            foreach (int g in f)
            {
                Console.WriteLine(g);
            }
            String[] fs = (String[])Enum.GetNames(typeof(MyEnum));

            foreach (String gs in fs)
            {
                Console.WriteLine(gs);
            }
            Console.WriteLine(Enum.GetName(typeof(MyEnum), 10));
            Console.ReadLine();
        }

        public enum MyEnum : short
        {
            unknown = 10,
            male = 5,
            femal = 58
        }
    }
}