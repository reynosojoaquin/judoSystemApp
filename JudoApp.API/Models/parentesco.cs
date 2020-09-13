namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class parentesco
    {
        [Key]
        public int parentescoID { get; set; }
        public int Descripcion { get; set; }
    }
}