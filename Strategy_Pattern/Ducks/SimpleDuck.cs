﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override void Display() // обязательное переопределение абстрактного метода
        {
            Console.WriteLine("I'm a simple duck!");
        }
    }
}
