using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    class RegexUsingLambda
    {
        public static string Regex_password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$";

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="Pass">The pass.</param>
        /// <returns></returns>
        public bool validatePassword(string Pass)
        {
            Regex pass = new Regex(Regex_password);
            bool password = pass.IsMatch(Pass);
            return password;
        }
        public static Func<string, bool> validateuserpassword = Pass => Regex.IsMatch(Pass, Regex_password);
    }
}
