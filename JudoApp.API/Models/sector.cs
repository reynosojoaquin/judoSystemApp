namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public class sector
    {
        [Key]
        public int sectorID { get; set; }
        public int ciudadID { get; set; }
        public String Descripcion { get; set; }
    }
}