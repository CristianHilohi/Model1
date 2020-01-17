using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model1.Models
{
    public class Film
    {
        private FilmDBContext db = new FilmDBContext();
    }

    public class FilmDBContext : DbContext
    {
        public FilmDBContext() : base("DBConnectionString") { }
        public DbSet<Film> Filme { get; set; }
    }
}