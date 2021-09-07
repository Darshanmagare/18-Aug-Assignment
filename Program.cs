using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World!");

            Arithmetic a = new Arithmetic();
            a.arithoperation(10, 2);

            Str obj1 = new Str();
            obj1.StriOperations("Hello India", "Hello World");

            Conditional obj2 = new Conditional();
            Console.WriteLine("********************Conditional Operator Output**********************");
            string res = obj2.GetWeatherDisplay(25);
            Console.WriteLine("Temperature is : " + res);
            Console.WriteLine();

            AssignmentOperator obj3 = new AssignmentOperator();
            obj3.assoperation(10);

            Logical obj4 = new Logical();
            obj4.logic();
            obj4.logicalor();

            //Unary obj5 = new Unary();
            //obj5.unaryoperation();


        }
    }


    class Arithmetic
    {
        public void arithoperation(int num1, int num2)
        {

            Console.WriteLine("*********Arithmetic Operator Output**********");
            int ans = num1 + num2;
            Console.WriteLine("Addition is :" + ans);

            int suntract = num1 - num2;
            Console.WriteLine("Subtraction is :" + suntract);

            int multi = num1 * num2;
            Console.WriteLine("Multiplication is :" + multi);

            int division = num1 / num2;
            Console.WriteLine("Division is :" + division);

            int modulo = num1 % num2;
            Console.WriteLine("Division is :" + modulo);
        }

    }

    class AssignmentOperator
    {
        public void assoperation(int num1)
        {

            Console.WriteLine("*********Assignment Operator Output**********");
            num1 += 10;
            Console.WriteLine("Value of a :" + num1);
            num1 -= 10;
            Console.WriteLine("Value of a :" + num1);
            num1 *= 10;
            Console.WriteLine("Value of a :" + num1);
            num1 /= 10;
            Console.WriteLine("Value of a :" + num1);
            num1 |= 10;
            Console.WriteLine("Value of a :" + num1);
            num1 %= 10;
            Console.WriteLine("Value of a :" + num1);
            num1 &= 10;
            Console.WriteLine("Value of a :" + num1);
            num1 ^= 10;
            Console.WriteLine("Value of a :" + num1);


        }

    }

    class Str
    {
        public void StriOperations(string s1, string s2)
        {
            Console.WriteLine("*********String Operator Output**********");
            //string s1 = "Hello World";
            //string s2 = "Hello World";



            //string match = s1.CompareTo(s2);
            //Console.WriteLine(match);

            //if (s.Equals(s1))
            //{
            //    Console.WriteLine("Strings are Equal");

            //}
            //else
            //{
            //    Console.WriteLine("Strings are not Equal");
            //}

            string ans = s1 + s2;
            Console.WriteLine("String Concatenation :" + ans);
            Console.WriteLine(String.Equals(s1, s2));
            Console.WriteLine(s1.StartsWith("Hello"));
            Console.WriteLine(s1.EndsWith("World"));
            Console.WriteLine(s2.StartsWith("Hi"));
            Console.WriteLine(s1.IndexOf("o"));
            Console.WriteLine(s1.LastIndexOf("India"));
        }
    }
    class Conditional
    {
        public string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

    }

    class Logical
    {
        int a = 10;
        int b = 18;
        int c = 18;
        int d = 0;


        //Console.WriteLine("Var1 =" + a);
        //Console.WriteLine("Var2 =" + b);
        //Console.WriteLine("Var3 =" + c);
        public void logic()
        {
            if ((a < b) && (b == c))
            {
                int d = a + b + c;
                Console.WriteLine("************Logical Operatot Output*********");
                Console.WriteLine("The sum is: " + d);
            }
            else
            {
                Console.WriteLine("False conditions");
            }
        }

        public void logicalor()
        {
            if (a > b || c == d)
                Console.WriteLine("One or both"
                                   + " the conditions are true");
            else
                Console.WriteLine("Both the"
                                   + " conditions are false");

            Console.WriteLine("Logical not operation :");
            Console.WriteLine("!(a < b) = " + !(a < b));
            Console.WriteLine("!(a > b) = " + !(a > b));

        }
        
    }

    //class Unary
    //{
    //    public unaryoperation(int num)
    //    {
    //        num = 5;

    //        Console.WriteLine("Post "

    //                           + "increment = " + num++);
    //        Console.WriteLine("Pre "
    //                           + "increment = " + ++num);

 

    //    }
    //}


}
