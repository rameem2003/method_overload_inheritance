using System;

namespace method_overoading_inheritance
{
    class addition
    {
        public void add(int a, int b)
        {
            int add = a + b;
            Console.WriteLine("The result of {0} + {1} is: {2}", a, b, add);
        }
        public void add(int a, int b, int c)
        {
            int add = a + b + c;
            Console.WriteLine("The result of {0} + {1} + {2} is: {3}", a, b, c, add);
        }
    }


    class app_body
    {
        public static void Main()
        {
            addition add = new addition();
            add.add(500, 600);
            add.add(500, 600, 1000);
        }
    }
}