namespace JudoApp.API.Models
{
    using System;
    public class atleta
    {
        public int atletaID { get; set; }
        public int personaID { get; set; }
        public virtual historialDeportivo HistorialDeportivo {get;set;}
        public bool activo { get; set; }
        public decimal indiceDeportivo { get; set; }
    }
}