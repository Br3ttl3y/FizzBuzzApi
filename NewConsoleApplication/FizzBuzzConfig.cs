﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApi
{
    public class FizzBuzzConfig
    {
        public int Start { get; set; }
        public int End { get; set; }
        public Dictionary<int, string> Words { get; set; }
    }
}
