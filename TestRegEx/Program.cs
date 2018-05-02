using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestRegEx
{
    class Program
    {
        static void Main(string[] args)
        {

            // First Method: Name
            CheckNames();

            // Second Method: Email
            CheckEmail();

            // Third Method: Phone "Area Code" xxx-xxx-xxxx
            CheckPhone();

            // Fourth Method: Date DD/MM/YYYY
            CheckDate();
        }

        public static void CheckNames()
        {
            Console.WriteLine("Please Enter Your Name:");
            string Input = Console.ReadLine();

            while (!Regex.IsMatch(Input, @"[A-Z][a-zA-Z\s]{4,29}$"))
            {
                Console.WriteLine("Invalid Name!\nPlease try again, using only Alphabets AND Capitalize the First Letter of Your Name.");

                Input = Console.ReadLine();
            }

            
            Console.WriteLine("Thank you," + Input + ". You have entered a valid name");
            Console.WriteLine();

        }

                        // Second Method: validation on the user's inpit to check for valid Email Adress

                                                    //Input Email Address

        public static bool CheckEmail()
        {

            Console.WriteLine("Please Enter Your Email Address");
            string Input = Console.ReadLine();

            if (!Regex.IsMatch(Input, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
            {
                Console.WriteLine("Invalid Email Address!\nPlease re-enter Your Email Address");

                return false;
            }
            else
            {
                Console.WriteLine("Thank You Have Entered a Valid Email Address");
                return true;
               
            }
        }

                        // Third Method: validation on the user's inpit to check for valid Phone Number

                                            //Input Phone Number

        public static bool CheckPhone()
        {
            Console.WriteLine("Please Enter Your Phone Number");
            string Input = Console.ReadLine();

            if (!Regex.IsMatch(Input, @"^[2-9]\d{2}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("Invalid Phone Number!\nPlease re-enter Your Phone Number");

                return false;
            }
            else
            {
                Console.WriteLine("Thank you!\nYou have entered a valid phone number");
                return true;
            }

        }

                            // Fourth Method: validation on the user's inpit to check for Valid Date

                                    // Input a Date


        public static bool CheckDate()
        {
            Console.WriteLine("Please Enter a Date in DD/MM/YYYY Format");
            string Input = Console.ReadLine();

            if (!Regex.IsMatch(Input, @"^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d\:[0-5]\d)$"))
            {
                Console.WriteLine("Invalid Date!\nPlease re-enter Your Date");

                return false;
            }
            else
            {
                Console.WriteLine("Thank You Have Entered a Valid Date");
                return true;
            }

        }


    }
}
