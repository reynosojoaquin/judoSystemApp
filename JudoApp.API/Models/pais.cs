namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class pais
    {
         [Key]
         public int paisID { get; set; }
         public String Descripcion { get; set; }
         public virtual provincia Provincia {get;set;}
    }
}