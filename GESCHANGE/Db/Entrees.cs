//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GESCHANGE.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrees
    {
        public int entr_ID { get; set; }
        public string entr_Fournisseur { get; set; }
        public Nullable<System.DateTime> entr_Date { get; set; }
        public string entr_Refference { get; set; }
        public Nullable<int> entr_Quantite { get; set; }
        public string entr_Note { get; set; }
        public Nullable<int> pies_ID { get; set; }
    
        public virtual Pieces Pieces { get; set; }
    }
}
