using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionAndAuthentication
{ 
    class Program
    {
        private  static Dictionary<string, string> accountList = new Dictionary<string, string>();

        public static void Main(string[] args)
        {
            WelcomeMenu();
        }

        // Initial user interface.
        private static void WelcomeMenu()
        {
            Console.Clear();
            Console.WriteLine(
                "--------------------------------------------------------------------\n" +

                "\n          PASSWORD AUTHENTICATION SYSTEM\n" +

                "\n          Please select one option:\n" +
                "          1.Establish an account\n" +
                "          2.Authenticate a user\n" +
                "          3.Exit the system\n" +

                "\n          Enter selection:\n" +

                "\n--------------------------------------------------------------------"
                );
            WelcomeMenuSelection();
        }

        // Takes user input to either create a new account, authenticate or exit console.
        private static void WelcomeMenuSelection()
        {
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1 || userInput == 2 || userInput == 3)
            {
                switch (userInput)
                {
                    case 1:
                        NewAccount();
                        break;
                    case 2:
                        Authenticate();
                        break;
                    case 3:
                        PrintAll();
                        accountList.Clear();
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter 1, 2, or 3.");
                WelcomeMenuSelection();
            }
        }

        // Takes user input and adds the username and password to the dictionary.
        private static void NewAccount()
        {
            Console.Clear();

            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();

            if (accountList.ContainsKey(userName))
            {
                Console.WriteLine("Username has been taken. Press enter to start again.");
                Console.ReadLine();
                NewAccount();
            }

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            string encryptedPassword = Encryptor.MD5Hash(password);
            Console.WriteLine();

            accountList.Add(userName, encryptedPassword);
            Console.WriteLine($"Username: {userName}\n" +
                $"Password: {password}\n" +
                $"Encrypted Password: {encryptedPassword}");

            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadLine();
            WelcomeMenu();
        }

        // Takes user input and checks if the username and password exist in the dictionary.
        private static void Authenticate()
        {
            Console.Clear();

            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (!accountList.ContainsKey(userName))
            {
                Console.WriteLine("Account does not exist. Press enter to try again.");
                Console.ReadLine();
                Authenticate();
            }

            string encryptedPassword = Encryptor.MD5Hash(password);
            accountList.TryGetValue(userName, out password);
            if (accountList.TryGetValue(userName, out password) && password == encryptedPassword)
            {
                Console.WriteLine("Account has been authenticated");
                Console.WriteLine("Press enter to return to the main menu.");
                Console.ReadLine();
                WelcomeMenu();
            }
            else
            {
                Console.WriteLine("Incorrect Username or Password. Press enter to try again.");
                Console.ReadLine();
                Authenticate();
            }
        }

        // Prints the entire dictionary with username and encrypted passwords.
        private static void PrintAll()
        {

            Console.WriteLine("\nDeleting the following accounts:");
            foreach (KeyValuePair<string, string> element in accountList)
            {
                string userName = element.Key;
                string password = element.Value;
                Console.WriteLine($"Username: {userName} | Password: {password}");
            }
        }
        // Encrypts the password.
        public static class Encryptor
        {
            public static string MD5Hash(string password)
            {
                MD5 md5 = new MD5CryptoServiceProvider();

                //compute hash from the bytes of text
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

                // get hash result after compute
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    // change it to 2 hexadecimal digits for each byte
                    strBuilder.Append(result[i].ToString("x2"));
                }

                return strBuilder.ToString();
            }
        }
    }
}
