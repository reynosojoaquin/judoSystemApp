
namespace JudoApp.API.Models
{
    using System;
    public class Club
    {
        public int ClubID { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String nombre { get; set; }
        public bool activo { get; set; }
        public virtual Telefono Telefono {get; set;}
        public virtual Direccion Direccion{get;set;}
        public virtual contacto contacto {get;set;}
        public virtual comiteEjecutivo ComiteEjecutivo {get;set;}
    }
}