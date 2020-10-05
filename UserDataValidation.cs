using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class UserDataValidation
    {
        /// <summary>
        /// Regular Expression for matching parameters
        /// </summary>
        public static string FIRSTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LASTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAIL_REGX = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public static string MOBILENUMBER_REGX = "^[0-9]{2}[ ][0-9]{10}$";
        /// <summary>
        /// Determines whether [is valid first name] [the specified first name].
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>
        ///   <c>true</c> if [is valid first name] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        public bool isValidEmailID(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_REGX);
        }
        public bool isValidFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRSTNAME_REGX);
        }

        public bool isValidLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LASTNAME_REGX);
        }

        public bool isValidMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILENUMBER_REGX);
        }

    }
}
