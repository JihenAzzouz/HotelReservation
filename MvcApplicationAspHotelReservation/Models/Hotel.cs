//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplicationAspHotelReservation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hotel
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string Ville { get; set; }
        public Nullable<int> chambres { get; set; }
    }
}
