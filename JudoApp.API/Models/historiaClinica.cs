namespace JudoApp.API.Models
{
    using System;
     using System.ComponentModel.DataAnnotations;
    public enum relevancia
    {
        Alta,Media,Baja
    }
    public class historiaClinica
    {

        [Key]
        public int historiaclinicaID { get; set; }
        public  int personaID  { get; set; }
        public int historialTipoID { get; set; }
        public String descripcion { get; set; }
        public relevancia? relevancia { get; set; }
    }
}