﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEntity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductNum { get; set; }
        public Order Order { get; set; }
    }
}
