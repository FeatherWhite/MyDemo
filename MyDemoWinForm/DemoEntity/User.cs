using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEntity
{
    public class User
    {
        public User()
        {
            Orders = new List<Order>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
