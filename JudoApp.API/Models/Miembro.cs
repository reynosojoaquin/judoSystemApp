namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public enum circunscripcion
    {
        Primera,Segunda
    }
    public enum sexo
    {
        masculino,
        femenino
    }
    public enum nivelEducativo
    {
        Primaria,Secundario,Grado,Maestria,Doctorado
    }
    public class Miembro
    {
        [Key]
        public int miembroID {get;set;}
        public Guid personaID { get; set; }
        public string referencia { get; set; }
        public virtual Club? club { get; set; }
        public int clubID {get;set;}
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaIngredo { get; set; }
        public sexo? sexo {get;set;}
        public string sexoDescripcion { get; set; }
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