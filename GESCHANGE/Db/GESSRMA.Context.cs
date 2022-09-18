﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GESSRMAEntities : DbContext
    {
        public GESSRMAEntities()
            : base("name=GESSRMAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Entrees> Entrees { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Pieces> Pieces { get; set; }
        public virtual DbSet<Sorties> Sorties { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vehicules> Vehicules { get; set; }
        public virtual DbSet<View_EP_Entrees> View_EP_Entrees { get; set; }
        public virtual DbSet<View_SP_Sorties> View_SP_Sorties { get; set; }
        public virtual DbSet<View_VL_Grade> View_VL_Grade { get; set; }
    
        public virtual ObjectResult<Select_Pieces_Result> Select_Pieces()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Pieces_Result>("Select_Pieces");
        }
    
        public virtual int Insert_Pieces(Nullable<int> pies_ID, string pies_Nom, string pies_Refference, Nullable<int> pies_Quantite, string pies_Note)
        {
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            var pies_NomParameter = pies_Nom != null ?
                new ObjectParameter("pies_Nom", pies_Nom) :
                new ObjectParameter("pies_Nom", typeof(string));
    
            var pies_RefferenceParameter = pies_Refference != null ?
                new ObjectParameter("pies_Refference", pies_Refference) :
                new ObjectParameter("pies_Refference", typeof(string));
    
            var pies_QuantiteParameter = pies_Quantite.HasValue ?
                new ObjectParameter("pies_Quantite", pies_Quantite) :
                new ObjectParameter("pies_Quantite", typeof(int));
    
            var pies_NoteParameter = pies_Note != null ?
                new ObjectParameter("pies_Note", pies_Note) :
                new ObjectParameter("pies_Note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Pieces", pies_IDParameter, pies_NomParameter, pies_RefferenceParameter, pies_QuantiteParameter, pies_NoteParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> MaxID_Pieces()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MaxID_Pieces");
        }
    
        public virtual ObjectResult<Pieces> Select_Pieces_By_ID(Nullable<int> pies_ID)
        {
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pieces>("Select_Pieces_By_ID", pies_IDParameter);
        }
    
        public virtual ObjectResult<Pieces> Select_Pieces_By_ID(Nullable<int> pies_ID, MergeOption mergeOption)
        {
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pieces>("Select_Pieces_By_ID", mergeOption, pies_IDParameter);
        }
    
        public virtual int Update_Pieces(Nullable<int> pies_ID, string pies_Nom, string pies_Refference, Nullable<int> pies_Quantite, string pies_Note)
        {
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            var pies_NomParameter = pies_Nom != null ?
                new ObjectParameter("pies_Nom", pies_Nom) :
                new ObjectParameter("pies_Nom", typeof(string));
    
            var pies_RefferenceParameter = pies_Refference != null ?
                new ObjectParameter("pies_Refference", pies_Refference) :
                new ObjectParameter("pies_Refference", typeof(string));
    
            var pies_QuantiteParameter = pies_Quantite.HasValue ?
                new ObjectParameter("pies_Quantite", pies_Quantite) :
                new ObjectParameter("pies_Quantite", typeof(int));
    
            var pies_NoteParameter = pies_Note != null ?
                new ObjectParameter("pies_Note", pies_Note) :
                new ObjectParameter("pies_Note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Pieces", pies_IDParameter, pies_NomParameter, pies_RefferenceParameter, pies_QuantiteParameter, pies_NoteParameter);
        }
    
        public virtual int Delete_Pieces(Nullable<int> pies_ID)
        {
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Pieces", pies_IDParameter);
        }
    
        public virtual int Delete_Vehicules(Nullable<int> vl_ID)
        {
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Vehicules", vl_IDParameter);
        }
    
        public virtual int Insert_Vehicules(Nullable<int> vl_ID, string vl_Matricule, string vl_Genre, string vl_Marque, string cond_Nom, string cond_Prenom, Nullable<int> grd_ID, string cond_Mle, string cond_Unite)
        {
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            var vl_MatriculeParameter = vl_Matricule != null ?
                new ObjectParameter("vl_Matricule", vl_Matricule) :
                new ObjectParameter("vl_Matricule", typeof(string));
    
            var vl_GenreParameter = vl_Genre != null ?
                new ObjectParameter("vl_Genre", vl_Genre) :
                new ObjectParameter("vl_Genre", typeof(string));
    
            var vl_MarqueParameter = vl_Marque != null ?
                new ObjectParameter("vl_Marque", vl_Marque) :
                new ObjectParameter("vl_Marque", typeof(string));
    
            var cond_NomParameter = cond_Nom != null ?
                new ObjectParameter("cond_Nom", cond_Nom) :
                new ObjectParameter("cond_Nom", typeof(string));
    
            var cond_PrenomParameter = cond_Prenom != null ?
                new ObjectParameter("cond_Prenom", cond_Prenom) :
                new ObjectParameter("cond_Prenom", typeof(string));
    
            var grd_IDParameter = grd_ID.HasValue ?
                new ObjectParameter("grd_ID", grd_ID) :
                new ObjectParameter("grd_ID", typeof(int));
    
            var cond_MleParameter = cond_Mle != null ?
                new ObjectParameter("cond_Mle", cond_Mle) :
                new ObjectParameter("cond_Mle", typeof(string));
    
            var cond_UniteParameter = cond_Unite != null ?
                new ObjectParameter("cond_Unite", cond_Unite) :
                new ObjectParameter("cond_Unite", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Vehicules", vl_IDParameter, vl_MatriculeParameter, vl_GenreParameter, vl_MarqueParameter, cond_NomParameter, cond_PrenomParameter, grd_IDParameter, cond_MleParameter, cond_UniteParameter);
        }
    
        public virtual ObjectResult<Vehicules> Select_Vehicules_By_ID(Nullable<int> vl_ID)
        {
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Vehicules>("Select_Vehicules_By_ID", vl_IDParameter);
        }
    
        public virtual ObjectResult<Vehicules> Select_Vehicules_By_ID(Nullable<int> vl_ID, MergeOption mergeOption)
        {
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Vehicules>("Select_Vehicules_By_ID", mergeOption, vl_IDParameter);
        }
    
        public virtual int Update_Vehicules(Nullable<int> vl_ID, string vl_Matricule, string vl_Genre, string vl_Marque, string cond_Nom, string cond_Prenom, Nullable<int> grd_ID, string cond_Mle, string cond_Unite)
        {
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            var vl_MatriculeParameter = vl_Matricule != null ?
                new ObjectParameter("vl_Matricule", vl_Matricule) :
                new ObjectParameter("vl_Matricule", typeof(string));
    
            var vl_GenreParameter = vl_Genre != null ?
                new ObjectParameter("vl_Genre", vl_Genre) :
                new ObjectParameter("vl_Genre", typeof(string));
    
            var vl_MarqueParameter = vl_Marque != null ?
                new ObjectParameter("vl_Marque", vl_Marque) :
                new ObjectParameter("vl_Marque", typeof(string));
    
            var cond_NomParameter = cond_Nom != null ?
                new ObjectParameter("cond_Nom", cond_Nom) :
                new ObjectParameter("cond_Nom", typeof(string));
    
            var cond_PrenomParameter = cond_Prenom != null ?
                new ObjectParameter("cond_Prenom", cond_Prenom) :
                new ObjectParameter("cond_Prenom", typeof(string));
    
            var grd_IDParameter = grd_ID.HasValue ?
                new ObjectParameter("grd_ID", grd_ID) :
                new ObjectParameter("grd_ID", typeof(int));
    
            var cond_MleParameter = cond_Mle != null ?
                new ObjectParameter("cond_Mle", cond_Mle) :
                new ObjectParameter("cond_Mle", typeof(string));
    
            var cond_UniteParameter = cond_Unite != null ?
                new ObjectParameter("cond_Unite", cond_Unite) :
                new ObjectParameter("cond_Unite", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Vehicules", vl_IDParameter, vl_MatriculeParameter, vl_GenreParameter, vl_MarqueParameter, cond_NomParameter, cond_PrenomParameter, grd_IDParameter, cond_MleParameter, cond_UniteParameter);
        }
    
        public virtual ObjectResult<Select_Vehicules_Result> Select_Vehicules()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Vehicules_Result>("Select_Vehicules");
        }
    
        public virtual ObjectResult<Nullable<int>> MaxID_Grades()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MaxID_Grades");
        }
    
        public virtual int Delete_Grades(Nullable<int> grd_ID)
        {
            var grd_IDParameter = grd_ID.HasValue ?
                new ObjectParameter("grd_ID", grd_ID) :
                new ObjectParameter("grd_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Grades", grd_IDParameter);
        }
    
        public virtual int Insert_Grades(Nullable<int> grd_ID, string grd_Libelle)
        {
            var grd_IDParameter = grd_ID.HasValue ?
                new ObjectParameter("grd_ID", grd_ID) :
                new ObjectParameter("grd_ID", typeof(int));
    
            var grd_LibelleParameter = grd_Libelle != null ?
                new ObjectParameter("grd_Libelle", grd_Libelle) :
                new ObjectParameter("grd_Libelle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Grades", grd_IDParameter, grd_LibelleParameter);
        }
    
        public virtual int Update_Grades(Nullable<int> grd_ID, string grd_Libelle)
        {
            var grd_IDParameter = grd_ID.HasValue ?
                new ObjectParameter("grd_ID", grd_ID) :
                new ObjectParameter("grd_ID", typeof(int));
    
            var grd_LibelleParameter = grd_Libelle != null ?
                new ObjectParameter("grd_Libelle", grd_Libelle) :
                new ObjectParameter("grd_Libelle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Grades", grd_IDParameter, grd_LibelleParameter);
        }
    
        public virtual ObjectResult<Select_Grades_Result> Select_Grades()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Grades_Result>("Select_Grades");
        }
    
        public virtual ObjectResult<Nullable<int>> MaxID_Vehicules()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MaxID_Vehicules");
        }
    
        public virtual ObjectResult<Select_View_VL_Grade_Result> Select_View_VL_Grade()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_View_VL_Grade_Result>("Select_View_VL_Grade");
        }
    
        public virtual ObjectResult<Select_View_EP_Entrees_Result> Select_View_EP_Entrees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_View_EP_Entrees_Result>("Select_View_EP_Entrees");
        }
    
        public virtual int Delete_Entrees(Nullable<int> entr_ID)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Entrees", entr_IDParameter);
        }
    
        public virtual int Insert_Entrees(Nullable<int> entr_ID, string entr_Fournisseur, Nullable<System.DateTime> entr_Date, string entr_Refference, Nullable<int> entr_Quantite, string entr_Note, Nullable<int> pies_ID)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(int));
    
            var entr_FournisseurParameter = entr_Fournisseur != null ?
                new ObjectParameter("entr_Fournisseur", entr_Fournisseur) :
                new ObjectParameter("entr_Fournisseur", typeof(string));
    
            var entr_DateParameter = entr_Date.HasValue ?
                new ObjectParameter("entr_Date", entr_Date) :
                new ObjectParameter("entr_Date", typeof(System.DateTime));
    
            var entr_RefferenceParameter = entr_Refference != null ?
                new ObjectParameter("entr_Refference", entr_Refference) :
                new ObjectParameter("entr_Refference", typeof(string));
    
            var entr_QuantiteParameter = entr_Quantite.HasValue ?
                new ObjectParameter("entr_Quantite", entr_Quantite) :
                new ObjectParameter("entr_Quantite", typeof(int));
    
            var entr_NoteParameter = entr_Note != null ?
                new ObjectParameter("entr_Note", entr_Note) :
                new ObjectParameter("entr_Note", typeof(string));
    
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Entrees", entr_IDParameter, entr_FournisseurParameter, entr_DateParameter, entr_RefferenceParameter, entr_QuantiteParameter, entr_NoteParameter, pies_IDParameter);
        }
    
        public virtual int Update_Entrees(Nullable<int> entr_ID, string entr_Fournisseur, Nullable<System.DateTime> entr_Date, string entr_Refference, Nullable<int> entr_Quantite, string entr_Note, Nullable<int> pies_ID)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(int));
    
            var entr_FournisseurParameter = entr_Fournisseur != null ?
                new ObjectParameter("entr_Fournisseur", entr_Fournisseur) :
                new ObjectParameter("entr_Fournisseur", typeof(string));
    
            var entr_DateParameter = entr_Date.HasValue ?
                new ObjectParameter("entr_Date", entr_Date) :
                new ObjectParameter("entr_Date", typeof(System.DateTime));
    
            var entr_RefferenceParameter = entr_Refference != null ?
                new ObjectParameter("entr_Refference", entr_Refference) :
                new ObjectParameter("entr_Refference", typeof(string));
    
            var entr_QuantiteParameter = entr_Quantite.HasValue ?
                new ObjectParameter("entr_Quantite", entr_Quantite) :
                new ObjectParameter("entr_Quantite", typeof(int));
    
            var entr_NoteParameter = entr_Note != null ?
                new ObjectParameter("entr_Note", entr_Note) :
                new ObjectParameter("entr_Note", typeof(string));
    
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Entrees", entr_IDParameter, entr_FournisseurParameter, entr_DateParameter, entr_RefferenceParameter, entr_QuantiteParameter, entr_NoteParameter, pies_IDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> MaxID_Entrees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MaxID_Entrees");
        }
    
        public virtual ObjectResult<Entrees> Select_Entrees_By_ID(Nullable<int> entr_ID)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Entrees>("Select_Entrees_By_ID", entr_IDParameter);
        }
    
        public virtual ObjectResult<Entrees> Select_Entrees_By_ID(Nullable<int> entr_ID, MergeOption mergeOption)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Entrees>("Select_Entrees_By_ID", mergeOption, entr_IDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> MaxID_Sorties()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MaxID_Sorties");
        }
    
        public virtual ObjectResult<Sorties> Select_Sorties_By_ID(Nullable<int> srt_ID)
        {
            var srt_IDParameter = srt_ID.HasValue ?
                new ObjectParameter("srt_ID", srt_ID) :
                new ObjectParameter("srt_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sorties>("Select_Sorties_By_ID", srt_IDParameter);
        }
    
        public virtual ObjectResult<Sorties> Select_Sorties_By_ID(Nullable<int> srt_ID, MergeOption mergeOption)
        {
            var srt_IDParameter = srt_ID.HasValue ?
                new ObjectParameter("srt_ID", srt_ID) :
                new ObjectParameter("srt_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sorties>("Select_Sorties_By_ID", mergeOption, srt_IDParameter);
        }
    
        public virtual ObjectResult<Select_View_SP_Sorties_Result> Select_View_SP_Sorties()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_View_SP_Sorties_Result>("Select_View_SP_Sorties");
        }
    
        public virtual int Delete_Sorties(Nullable<int> srt_ID)
        {
            var srt_IDParameter = srt_ID.HasValue ?
                new ObjectParameter("srt_ID", srt_ID) :
                new ObjectParameter("srt_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Sorties", srt_IDParameter);
        }
    
        public virtual int Insert_Sorties(Nullable<int> srt_ID, Nullable<System.DateTime> srt_Date, string srt_Refference, Nullable<int> srt_Quantite, string srt_Note, Nullable<int> vl_ID, Nullable<int> pies_ID)
        {
            var srt_IDParameter = srt_ID.HasValue ?
                new ObjectParameter("srt_ID", srt_ID) :
                new ObjectParameter("srt_ID", typeof(int));
    
            var srt_DateParameter = srt_Date.HasValue ?
                new ObjectParameter("srt_Date", srt_Date) :
                new ObjectParameter("srt_Date", typeof(System.DateTime));
    
            var srt_RefferenceParameter = srt_Refference != null ?
                new ObjectParameter("srt_Refference", srt_Refference) :
                new ObjectParameter("srt_Refference", typeof(string));
    
            var srt_QuantiteParameter = srt_Quantite.HasValue ?
                new ObjectParameter("srt_Quantite", srt_Quantite) :
                new ObjectParameter("srt_Quantite", typeof(int));
    
            var srt_NoteParameter = srt_Note != null ?
                new ObjectParameter("srt_Note", srt_Note) :
                new ObjectParameter("srt_Note", typeof(string));
    
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Sorties", srt_IDParameter, srt_DateParameter, srt_RefferenceParameter, srt_QuantiteParameter, srt_NoteParameter, vl_IDParameter, pies_IDParameter);
        }
    
        public virtual int Update_Sorties(Nullable<int> srt_ID, Nullable<System.DateTime> srt_Date, string srt_Refference, Nullable<int> srt_Quantite, string srt_Note, Nullable<int> vl_ID, Nullable<int> pies_ID)
        {
            var srt_IDParameter = srt_ID.HasValue ?
                new ObjectParameter("srt_ID", srt_ID) :
                new ObjectParameter("srt_ID", typeof(int));
    
            var srt_DateParameter = srt_Date.HasValue ?
                new ObjectParameter("srt_Date", srt_Date) :
                new ObjectParameter("srt_Date", typeof(System.DateTime));
    
            var srt_RefferenceParameter = srt_Refference != null ?
                new ObjectParameter("srt_Refference", srt_Refference) :
                new ObjectParameter("srt_Refference", typeof(string));
    
            var srt_QuantiteParameter = srt_Quantite.HasValue ?
                new ObjectParameter("srt_Quantite", srt_Quantite) :
                new ObjectParameter("srt_Quantite", typeof(int));
    
            var srt_NoteParameter = srt_Note != null ?
                new ObjectParameter("srt_Note", srt_Note) :
                new ObjectParameter("srt_Note", typeof(string));
    
            var vl_IDParameter = vl_ID.HasValue ?
                new ObjectParameter("vl_ID", vl_ID) :
                new ObjectParameter("vl_ID", typeof(int));
    
            var pies_IDParameter = pies_ID.HasValue ?
                new ObjectParameter("pies_ID", pies_ID) :
                new ObjectParameter("pies_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Sorties", srt_IDParameter, srt_DateParameter, srt_RefferenceParameter, srt_QuantiteParameter, srt_NoteParameter, vl_IDParameter, pies_IDParameter);
        }
    
        public virtual ObjectResult<Vehicules> Select_Vehicules_By_MleVL(string vl_Matricule)
        {
            var vl_MatriculeParameter = vl_Matricule != null ?
                new ObjectParameter("vl_Matricule", vl_Matricule) :
                new ObjectParameter("vl_Matricule", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Vehicules>("Select_Vehicules_By_MleVL", vl_MatriculeParameter);
        }
    
        public virtual ObjectResult<Vehicules> Select_Vehicules_By_MleVL(string vl_Matricule, MergeOption mergeOption)
        {
            var vl_MatriculeParameter = vl_Matricule != null ?
                new ObjectParameter("vl_Matricule", vl_Matricule) :
                new ObjectParameter("vl_Matricule", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Vehicules>("Select_Vehicules_By_MleVL", mergeOption, vl_MatriculeParameter);
        }
    
        public virtual ObjectResult<Pieces> Select_Pieces_By_Name(string pies_Nom)
        {
            var pies_NomParameter = pies_Nom != null ?
                new ObjectParameter("pies_Nom", pies_Nom) :
                new ObjectParameter("pies_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pieces>("Select_Pieces_By_Name", pies_NomParameter);
        }
    
        public virtual ObjectResult<Pieces> Select_Pieces_By_Name(string pies_Nom, MergeOption mergeOption)
        {
            var pies_NomParameter = pies_Nom != null ?
                new ObjectParameter("pies_Nom", pies_Nom) :
                new ObjectParameter("pies_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pieces>("Select_Pieces_By_Name", mergeOption, pies_NomParameter);
        }
    
        public virtual int Update_Pieces_Quantite_By_Name(string pies_Nom, Nullable<int> pies_Quantite)
        {
            var pies_NomParameter = pies_Nom != null ?
                new ObjectParameter("pies_Nom", pies_Nom) :
                new ObjectParameter("pies_Nom", typeof(string));
    
            var pies_QuantiteParameter = pies_Quantite.HasValue ?
                new ObjectParameter("pies_Quantite", pies_Quantite) :
                new ObjectParameter("pies_Quantite", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Pieces_Quantite_By_Name", pies_NomParameter, pies_QuantiteParameter);
        }
    }
}
