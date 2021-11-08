using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    class RegexUsingLambda
    {
        public static string pattern = "^[A-Z][a-z]{2,}$";
        public bool validateLastName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
    }
}
