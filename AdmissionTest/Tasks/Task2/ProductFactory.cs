﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ProductFactory<T> 
    {
        public T Create()
        {
            return default(T);
        }
    }
}
