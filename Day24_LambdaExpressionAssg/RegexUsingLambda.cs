using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    class RegexUsingLambda
    {
        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public bool validateEmail(string Email)
        {
            Regex mail = new Regex(Regex_Email);
            bool email = mail.IsMatch(Email);
            return email;
        }
        public static Func<string, bool> validateUserEmail = Email => Regex.IsMatch(Email, Regex_Email);
    }
}
