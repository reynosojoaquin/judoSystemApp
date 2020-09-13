namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class evento
    {
        [Key]
        public int eventoID { get; set; }
        public String descripcion { get; set; }
    }
}