﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.SimpleFactoryPattern
{
    public class Car : Product
    {
        public override string Name
        {
            get { return "Car"; }
        }
    }
}
