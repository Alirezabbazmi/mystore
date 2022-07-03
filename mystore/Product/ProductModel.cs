using System;
using System.Collections.Generic;
using System.Text;

namespace mystore.Product
{
    public class ProductModel
    {
        public int id { get; set; }
        public long PID{ get; set; }
        public string PName { get; set; }
        public long Amount { get; set; }
        public long Price { get; set; }
    }
}
