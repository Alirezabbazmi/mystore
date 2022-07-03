using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Product
{
    public class CartModel
    {
        public int id  { get; set; }
        public string PName  { get; set; }
        public long Amount  { get; set; }
        public long Price { get; set; }
        public string  UserFKey  { get; set; }
        public User.UserModel User { get; set; }
    }
}
