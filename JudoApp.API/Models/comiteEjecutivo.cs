namespace JudoApp.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class comiteEjecutivo
    {
        [Key]
        public int comiteEjecutivoID { get; set; }
        public int personaID { get; set; }
        public int clubID { get; set; }
        public int CargoID { get; set; }
    }
}