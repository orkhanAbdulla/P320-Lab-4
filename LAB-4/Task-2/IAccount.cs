﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    interface IAccount
    {
        bool PasswordCheker(string pass);
        void ShowInfo();
    }
}
