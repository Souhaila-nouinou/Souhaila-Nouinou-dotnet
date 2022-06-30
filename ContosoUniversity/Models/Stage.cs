namespace ContosoUniversity.Models
{
    public class Stage
    {




        public int StageID { get; set; }
       

        // public string Description { get; set; }

        // [Display(Name = "Organisme d'acceuil")]
        // public string OrganismeAceuil { get; set; }

        // [Display(Name = "Pays")]
        // public string Pays { get; set; }

        // [Display(Name = "Ville")]
        // public string Ville { get; set; }


        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // [Display(Name = "Date Début")]
        // public  DateTime  DateDebut { get; set; }
        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // [Display(Name = "Date Fin")]
        // public DateTime  DateFin { get; set; }

//-------------------------
        // public int id_student { get; set; }
        public Student Stagiaire { get; set; }

        public Student Binome { get; set; }

        public int EnseignantID { get; set; }
        public Instructor Encadrant { get; set; }

        public int SignatureValidation { get; set; } 
        public string sujet { get; set; }


//-----------------------------




        // public int ID { get; set; }
        // [ForeignKey("ID")]
        // public int id_student { get; set; }
        // public Etudiant Etudiant { get; set; }

        // [ForeignKey("ID_prof")]
        // public string id_prof { get; set; }
        // public Professeur Professeur { get; set; }

        // public string lien_PFE { get; set; }
        // public string sujet { get; set; }


    }
}