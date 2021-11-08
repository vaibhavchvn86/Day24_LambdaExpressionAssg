using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    class RegexUsingLambda
    {
        public static string Regex_mobilenum = "^[0-9]{2}[ ]?[6-9][0-9]{9}$";
        /// <summary>
        /// Validates the mobilenum.
        /// </summary>
        /// <param name="Mobile">The mobile.</param>
        /// <returns></returns>
        public bool validateMobilenum(string Mobile)
        {
            Regex Mob = new Regex(Regex_mobilenum);
            bool mobile = Mob.IsMatch(Mobile);
            return mobile;
        }
        public static Func<string, bool> validateuserMobile = Mobile => Regex.IsMatch(Mobile, Regex_mobilenum);
    }
}
