using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model1.Models
{
    /* Film:
     * IDFilm - int - cheie primara 
     * Denumire - string
     */
    public class Film
    {
        [Key]
        public int IDFilm { get; set; }

        public string Denumire { get; set; }
    }
}