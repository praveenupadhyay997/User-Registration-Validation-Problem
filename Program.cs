using System;

namespace UserRegistrationValidation
{
    class Program
    {
        /// <summary>
        /// All the member variable as the user data to be entered locally from user's
        /// </summary>
        public static string firstName;
 
        static void Main(string[] args)
        {
            UserDataValidation dataValidation = new UserDataValidation();
            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to User Registration Validation Program");
            Console.WriteLine("================================================");

            Console.WriteLine("Enter User First Name=");
            firstName = Console.ReadLine();

            bool validationKey = dataValidation.isValidFirstName(firstName);
            Console.WriteLine(validationKey ? "{0} is a Valid Name." : "{0} is Not a Valid Name.", firstName);

        }
    }
}
