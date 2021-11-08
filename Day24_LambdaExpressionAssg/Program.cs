using System;

namespace Day24_LambdaExpressionAssg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Check Using Lambda Expression/Function");
            RegexusingLambda FN = new RegexusingLambda();
            
            Console.WriteLine("\nEnter first Name");
            var Firstname = Console.ReadLine();
            Console.WriteLine(FN.validateFirstName(Firstname));
            
            Console.WriteLine("\nEnter Lastname");
            var Lastname = Console.ReadLine();
            Console.WriteLine(FN.validateLastName(Lastname));

            Console.WriteLine("\nEnter Email");
            var Email=Console.ReadLine();
            Console.WriteLine(FN.validateEmail(Email));

            Console.WriteLine("\nEnter MobileNumber");
            var Mobile = Console.ReadLine();
            Console.WriteLine(FN.validateMobilenum(Mobile));

            Console.WriteLine("\nEnter Password");
            var Pass = Console.ReadLine();
            Console.WriteLine(FN.validatePassword(Pass));
        }
    }
}
