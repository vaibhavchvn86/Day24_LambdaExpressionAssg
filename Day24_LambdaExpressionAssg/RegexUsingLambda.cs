using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    public class RegexusingLambda
    {
        /// <summary>
        ///UC13 Refactor the Code to use Lambda Function
        /// </summary>
        public static string pattern = "^[A-Z][a-z]{2,}$";
        public bool validateFirstName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
    }
}