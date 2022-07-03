using System;
using System.Collections.Generic;
using System.Text;

namespace mystore.Product
{
    public class CartModel
    {
        public int id  { get; set; }
        public long  PID { get; set; }
        public string  UserFKey  { get; set; }
        public User.UserModel User { get; set; }
    }
}
