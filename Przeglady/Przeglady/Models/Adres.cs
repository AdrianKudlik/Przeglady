using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Przeglady.Models
{

    public class Adres
    {
       [Key]
        public int ID { get; set; }

        [DisplayName("Ulica")]
        public string Ulica { get; set; }

        [DisplayName("Kod pocztowy")]
        public string Kod { get; set; }

        [DisplayName("Miejscowość")]
        public string Miejscowosc { get; set; }

        [DisplayName("Województwo")]
        public string Wojewodztwo { get; set; }

        public Adres(string ulica, string kod, string miejscowosc, string wojewodztwo)
        {
            this.Ulica = ulica;
            this.Kod = kod;
            this.Miejscowosc = miejscowosc;
            this.Wojewodztwo = wojewodztwo;
        }
        public Adres()
        {
          
        }

    }
}