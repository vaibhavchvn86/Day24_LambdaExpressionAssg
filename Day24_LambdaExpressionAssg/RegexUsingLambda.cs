using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24_LambdaExpressionAssg
{
    public class RegexusingLambda
    {
        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public static string Regex_mobilenum = "^[0-9]{2}[ ]?[6-9][0-9]{9}$";
        /// <summary>
        ///UC13 Refactor the Code to use Lambda Function
       
        /// Validates the mobilenum.
        /// </summary>
        public static string pattern = "^[A-Z][a-z]{2,}$";
        public bool validateLastName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
        public bool validateFirstName(string Name)
        { 
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
        /// Validates the email.
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public bool validateEmail(string Email)
        public bool validateMobilenum(string Mobile)
        {
            Regex Mob = new Regex(Regex_mobilenum);
            bool mobile = Mob.IsMatch(Mobile);
            return mobile;
           
            Regex mail = new Regex(Regex_Email);
            bool email = mail.IsMatch(Email);
            return email;
        }
        public static Func<string, bool> validateuserLname = Name => Regex.IsMatch(Name, pattern);

        public static Func<string, bool> validateuserFname = Name => Regex.IsMatch(Name, pattern);
        public static Func<string, bool> validateUserEmail = Email => Regex.IsMatch(Email, Regex_Email);
        public static Func<string, bool> validateuserMobile = Mobile => Regex.IsMatch(Mobile, Regex_mobilenum);
    }
}
