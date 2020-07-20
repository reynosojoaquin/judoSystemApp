namespace JudoApp.API.Models
{
    using System;
    public class contacto
    {
        public int contactoID { get; set; }
        public int personaID { get; set; }
        public int parentescoID { get; set; }
        public bool principal { get; set; }
    }
}