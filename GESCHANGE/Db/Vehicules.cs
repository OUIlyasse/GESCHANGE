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
    
    public partial class Vehicules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicules()
        {
            this.Sorties = new HashSet<Sorties>();
        }
    
        public int vl_ID { get; set; }
        public string vl_Matricule { get; set; }
        public string vl_Genre { get; set; }
        public string vl_Marque { get; set; }
        public string cond_Nom { get; set; }
        public string cond_Prenom { get; set; }
        public Nullable<int> grd_ID { get; set; }
        public string cond_Mle { get; set; }
        public string cond_Unite { get; set; }
    
        public virtual Grades Grades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sorties> Sorties { get; set; }
    }
}
