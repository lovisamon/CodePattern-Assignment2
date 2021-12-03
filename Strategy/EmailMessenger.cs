﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class EmailMessenger : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }
    }
}
