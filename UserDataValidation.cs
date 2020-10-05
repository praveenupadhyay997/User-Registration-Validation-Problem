using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class UserDataValidation
    {
        /// <summary>
        /// The firstname regx
        /// </summary>
        public static string FIRSTNAME_REGX = "^[A-Z]{1}[A-Za-z]{3,}$";
        /// <summary>
        /// Determines whether [is valid first name] [the specified first name].
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>
        ///   <c>true</c> if [is valid first name] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        public bool isValidFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRSTNAME_REGX);
        }
    }
}
