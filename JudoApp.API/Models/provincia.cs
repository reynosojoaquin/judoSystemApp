namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class provincia
    {
        [Key]
         public int provinciaID { get; set; }
         public int paisID { get; set; }
         public String Descripcion { get; set; }
    }
}