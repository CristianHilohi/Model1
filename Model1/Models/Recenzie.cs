using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model1.Models
{
    /* Recenzie:
     * IDRecenzie - int - cheie primara 
     * Titlu - string 
     * Descriere - text 
     * Nota - int - intre 1 si 5 
     * NumeUtilizator - string 
     * IDFilm - int - cheie straina
     */
    public class Recenzie
    {
        [Key]
        public int IDRecenzie { get; set; }

        public string Titlu { get; set; }

        public string Descriere { get; set; }

        [Range(1, 5)]
        //[MinValue(1, "Nota trebuie sa nu fie mai mica decat 1")]
        //[MaxValue(5, "Nota trebuie sa nu fie mai mare decat 5")]
        public int Nota { get; set; }

        public string NumeUtilizator { get; set; }

        public virtual int IDFilm { get; set; }
    }

    public class RecenzieDBContext : DbContext
    {
        public RecenzieDBContext() : base("DBConnectionString") { }
        public DbSet<Recenzie> Recenzii { get; set; }
        public DbSet<Film> Filme { get; set; }
    }
}