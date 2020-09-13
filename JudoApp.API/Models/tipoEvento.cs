namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class tipoEvento
    {
        [Key]
        public int tipoeventoID { get; set; }
        public String Descripcion { get; set; }
    }
}