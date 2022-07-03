using System;
using System.Collections.Generic;
using System.Text;

namespace Models.User
{
    public class UserModel
    {
        public Guid ID { get; set; }
        public string Username{ get; set; }
        public byte[] Password  { get; set; }
        public byte[] KeyPassword { get; set; }
        public List<Product.CartModel> Cart { get; set; }
    }
}
