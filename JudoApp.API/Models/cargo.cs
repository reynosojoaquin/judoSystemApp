namespace JudoApp.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class cargo
    {
        [Key]
        public int cargoID { get; set; }
        public String descripcion { get; set; }
    }
}