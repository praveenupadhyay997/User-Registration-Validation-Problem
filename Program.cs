using System;
using System.Collections.Generic;

namespace UserRegistrationValidation
{
    class Program
    {
        /// <summary>
        /// All the member variable as the user data to be entered locally from user's
        /// </summary>
        public static string firstName;
        public static string lastName;
        public static string emailId;
        public static string mobileNumber;
        public static string password;

        /// <summary>
        /// The email list
        /// </summary>
        public static List<string> emailList = new List<string>();

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            
            UserDataValidation dataValidation = new UserDataValidation();
            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to User Registration Validation Program");
            Console.WriteLine("================================================");
            
            
            bool validationKey;

            Console.WriteLine("Enter User First Name=");
            firstName = Console.ReadLine();

            validationKey = dataValidation.isValidFirstName(firstName);
            Console.WriteLine(validationKey ? "{0} is a Valid Name." : "{0} is Not a Valid First Name.", firstName);

            Console.WriteLine("Enter User Last Name=");
            lastName = Console.ReadLine();

            validationKey = dataValidation.isValidLastName(lastName);
            Console.WriteLine(validationKey ? "{0} is a Valid Last Name." : "{0} is Not a Valid Last Name.", lastName);

            do
            {
                Console.WriteLine("Enter User Email Id=");
                emailId = Console.ReadLine();

                validationKey = dataValidation.isValidEmailID(emailId);
                Console.WriteLine(validationKey ? "{0} is a Valid Email-ID." : "{0} is Not a Valid Email-ID.", emailId);
                if (validationKey)
                    emailList.Add(emailId);

                Console.WriteLine("Press y to add more valid email ids or any other key to stop adding");
            }
            while ((Console.ReadLine() == "y" || Console.ReadLine() == "Y"));

            Console.WriteLine("The List of all valid email-ids are = ");
            // To print all the valid email id-s entered by user
            foreach(var email in emailList)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("Enter User Password=");
            password = Console.ReadLine();

            validationKey = dataValidation.isValidPasswordUC8(password);
            Console.WriteLine(validationKey ? "{0} is a Valid Password." : "{0} is Not a Valid Password.", password);


        }
    }
}
