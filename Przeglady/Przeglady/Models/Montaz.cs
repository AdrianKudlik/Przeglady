using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;


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


        //[DisplayName("Adres Pracowni")]

        [DisplayName("Ulica")]
        public string Ulica { get; set; }

        [DisplayName("Kod pocztowy")]
        public string Kod { get; set; }

        [DisplayName("Miejscowość")]
        public string Miejscowosc { get; set; }

        [DisplayName("Województwo")]
        public string Wojewodztwo { get; set; }


        //[DisplayName("Adres montażu")]

        [DisplayName("Ulica")]
        public string Ulica2 { get; set; }

        [DisplayName("Kod pocztowy")]
        public string Kod2 { get; set; }

        [DisplayName("Miejscowość")]
        public string Miejscowosc2 { get; set; }

        [DisplayName("Województwo")]
        public string Wojewodztwo2 { get; set; }





        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [DisplayName("Telefon")]
        public string Telefon { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("NIP")]
        public string Nip { get; set; }

        [DisplayName("Czas gwarancji")]
        public string Gwarancja { get; set; }

        [DataType(DataType.Date)]
    //    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data montażu")]
        public DateTime DataMontazu { get; set; }

        [DataType(DataType.Date)]
      //  [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
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