namespace JudoApp.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class ciudad
    {
        [Key]
         public int ciudadID { get; set; }
         public int provinciaID { get; set; }
         public String Descripcion { get; set; }
         public virtual sector Sector {get;set;}
    }
}