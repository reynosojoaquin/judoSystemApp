namespace JudoApp.API.Models
{
    using System;
    public enum relevancia
    {
        Alta,Media,Baja
    }
    public class historiaClinica
    {
        public int historiaclinicaID { get; set; }
        public  int personaID  { get; set; }
        public int historialTipoID { get; set; }
        public String descripcion { get; set; }
        public relevancia? relevancia { get; set; }
    }
}