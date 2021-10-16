using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    class User : IAccount
    {
        private string _password;
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordCheker(value))
                {
                    _password = value;
                }
            }
        }
        public User(string email, string pass)
        {
            Email = email;
            Password = pass;
        }

        public bool PasswordCheker(string pass)
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

        public void ShowInfo()
        {
            Console.WriteLine($"fullname: {FullName} \nEmail:{Email}");

        }
    }
}
