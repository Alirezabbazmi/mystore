using System;
using System.Collections.Generic;
using System.Text;

namespace mystore.User
{
    public class UserModel
    {
        public Guid ID { get; set; }
        public string Username{ get; set; }
        public byte[] Password  { get; set; }
        public byte[] KeyPassword { get; set; }
        public Guid InviteCode { get; set; }
        public string PhoneNummber { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Product.CartModel> Cart { get; set; }
    }
}
