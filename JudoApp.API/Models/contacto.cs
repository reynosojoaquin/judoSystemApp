namespace JudoApp.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class contacto
    {
        [Key]
        public int contactoID { get; set; }
        public int personaID { get; set; }
        public int parentescoID { get; set; }
        public bool principal { get; set; }
    }
}