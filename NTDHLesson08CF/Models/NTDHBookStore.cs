using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NTDHLesson08CF.Models
{
    public class NTDHBookStore : DbContext
    {
        public NTDHBookStore() : base("NTDHBookStoreConnectionString)
        {

        }
        // Tạo các bảng
        public DbSet<NTDHCategory> NTDHCategories { get; set; }
        public DbSet<NTDHBook> NTDHBooks { get; set; }

    }
}