using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model1.Models
{
    public class Recenzie
    {
    }

    public class RecenzieDBContext : DbContext
    {
        public RecenzieDBContext() : base("DBConnectionString") { }
        public DbSet<Recenzie> Recenzii { get; set; }
    }
}