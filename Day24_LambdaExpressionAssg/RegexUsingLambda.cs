using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    public class RegexusingLambda
    {
        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        /// <summary>
        ///UC13 Refactor the Code to use Lambda Function
        /// Validates the email.
        /// </summary>
        public static string pattern = "^[A-Z][a-z]{2,}$";
        public bool validateLastName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
        public bool validateFirstName(string Name)
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public bool validateEmail(string Email)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
            Regex mail = new Regex(Regex_Email);
            bool email = mail.IsMatch(Email);
            return email;
        }
        public static Func<string, bool> validateuserLname = Name => Regex.IsMatch(Name, pattern);

        public static Func<string, bool> validateuserFname = Name => Regex.IsMatch(Name, pattern);
        public static Func<string, bool> validateUserEmail = Email => Regex.IsMatch(Email, Regex_Email);
    }
}
