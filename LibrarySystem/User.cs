﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal abstract class User
    {
        public string Name { get; set; }


        public void DisplayBook(Library library)
        {
            library.Display();

        }
    }
}
