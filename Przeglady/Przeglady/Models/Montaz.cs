using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Przeglady.Models
{
    public class Montaz
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nazwa pracowni")]
        public string Nazwa { get; set; }


        [DisplayName("Imię")]
        public string Imie { get; set; }

        [DisplayName("Nazwisko")]
        public string Nazwisko { get; set; }

        [DisplayName("Adres pracowni")]
        public Adres AdresPracowni { get; set; }

        [DisplayName("Adres montażu")]
        public Adres AdresMontazu { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [DisplayName("Telefon")]
        public string Telefon { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("NIP")]
        public string Nip { get; set; }

        [DisplayName("Zaproszenie")]
        public string Zaproszenie { get; set; }

        [DisplayName("Czas gwarancji")]
        public string Gwarancja { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data montażu")]
        public DateTime DataMontazu { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data ostatniego przeglądu")]
        public DateTime DataOstatniegoPrzegladu { get; set; }

        [DisplayName("Podręczniki:")]
        public bool Podreczniki { get; set; }

        [DisplayName("ODOiA:")]
        public bool ODOIA { get; set; }

        [DisplayName("Sigma:")]
        public bool SIGMA { get; set; }

        [DisplayName("Uwagi:")]
        [DataType(DataType.MultilineText)]
        public string Uwagi { get; set; }

     
    }
}