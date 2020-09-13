namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class historiaClinicaTipo
    {
        [Key]
       public  int historiaClinicaTipoID {get;set;}
       public String descripcion { get; set; }
    }
}