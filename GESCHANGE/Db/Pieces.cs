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
    
    public partial class Pieces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pieces()
        {
            this.Entrees = new HashSet<Entrees>();
            this.Sorties = new HashSet<Sorties>();
        }
    
        public int pies_ID { get; set; }
        public string pies_Nom { get; set; }
        public string pies_Refference { get; set; }
        public Nullable<int> pies_Quantite { get; set; }
        public string pies_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrees> Entrees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sorties> Sorties { get; set; }
    }
}
