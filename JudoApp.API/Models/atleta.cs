namespace JudoApp.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class atleta
    {
        [Key]
        public int atletaID { get; set; }
        public int personaID { get; set; }
        public virtual historialDeportivo HistorialDeportivo {get;set;}
        public bool activo { get; set; }
        public decimal indiceDeportivo { get; set; }
    }
}