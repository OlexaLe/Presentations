﻿using System;

namespace FormsSample
{
    class ComplexLogic
    {
        public string Reverse (string input)
        {
            var array = input.ToCharArray ();
            Array.Reverse (array);
            return new string (array);
        }
    }
}

