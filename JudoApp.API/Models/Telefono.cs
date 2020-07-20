namespace JudoApp.API.Models
{
    using System;
    public class Telefono
        {
        public int telefonoID { get; set; }
        public int referencia { get; set; }
        public int tipoID { get; set; }
        public String numeroTelefonico { get; set; }
        public bool principal { get; set; }
        public bool disponible { get; set; }

    }
}