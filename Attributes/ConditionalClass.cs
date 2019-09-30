﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class ConditionalClass
    {
        [Conditional("DEBUG")]
        public void Login()
        {
            ShowUI();
        }

        [Conditional("RELASE")]
        public void Login(string user, string passwd)
        {
            Console.WriteLine("1");
            LoginPage();
        }

        private void LoginPage()
        {
            Console.WriteLine("1");

            LoginPage2();
        }

        private void LoginPage2()
        {
            Console.WriteLine("1");
            ShowUI();
        }

        private void ShowUI()
        {
            Console.WriteLine("UI");
        }
    }
}
