using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using mystore.Product;

namespace mystore.dbContext
{
    public class ContextModel : Microsoft.EntityFrameworkCore.DbContext
    {
        public ContextModel(DbContextOptions<ContextModel> dbContextOptions) 
            : base(dbContextOptions)
        {

        }
        public DbSet<User.UserModel> Users { get; set; }
        public DbSet<CartModel> Products { get; set; }
       

    }
}
