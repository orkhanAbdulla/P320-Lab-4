using System;

namespace Task__2
{
    class Program
    {
        static void Main(string[] args)
        {   
            string email;
            string password;

            do
            {
                Console.WriteLine("Email daxil edin");
                email = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(email));

            do
            {
                Console.WriteLine("Sifrenizi daxil edin");
                password = Console.ReadLine();
            } while (!PasswordCheker(password));


            User user = new User("Orkhanaa@mail.ru", "Orkhanaa1");
            user.FullName = "Orkhan Abdullayev";
            user.ShowInfo();
        }
        public static bool PasswordCheker(string pass)
        {
            int digitCount = 0;
            int lowerCount = 0;
            int upperCount = 0;

            if (pass.Length > 7)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (Char.IsDigit(pass[i]))
                    {
                        digitCount++;
                    }
                    else if (Char.IsLower(pass[i]))
                    {
                        lowerCount++;

                    }
                    else if (Char.IsUpper(pass[i]))
                    {
                        upperCount++;
                    }
                    if (digitCount > 0 && lowerCount > 0 && upperCount > 0)
                    {
                        return true;
                    }

                }

            }
            return false;
        }
    }
}
