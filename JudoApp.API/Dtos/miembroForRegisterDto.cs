using System;
using JudoApp.API.Models;

namespace JudoApp.API.Dtos
{
    public class miembroForRegisterDto
    {
        public int miembroID { get; set; }
        public virtual Club Club { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaIngredo { get; set; }
        public sexo? sexo {get;set;}
        public virtual Telefono Telefono {get;set;}
        public String correoElectronico { get; set; }
        public virtual Direccion Direccion {get;set;}
        public bool activo { get; set; }
        public virtual contacto contacto {get;set;}
        public virtual historiaClinica HistoriaClinica {get;set;}
        public String cedula { get; set; }
        public String folio { get; set; }
        public circunscripcion? circunscripcion { get; set; }
        public nivelEducativo? nivelEducativo {get;set;}
    }
}