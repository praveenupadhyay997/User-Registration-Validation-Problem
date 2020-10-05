using System;

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
            Console.WriteLine(validationKey ? "{0} is a Valid Name." : "{0} is Not a Valid Name.", firstName);

            Console.WriteLine("Enter User Last Name=");
            lastName = Console.ReadLine();

            validationKey = dataValidation.isValidLastName(lastName);
            Console.WriteLine(validationKey ? "{0} is a Valid Name." : "{0} is Not a Valid Name.", lastName);

            Console.WriteLine("Enter User Email Id=");
            emailId = Console.ReadLine();

            validationKey = dataValidation.isValidEmailID(emailId);
            Console.WriteLine(validationKey ? "{0} is a Valid Name." : "{0} is Not a Valid Name.", emailId);

        }
    }
}
