namespace JudoApp.API.Models
{
    using System;
    public class Direccion
    {
        public int direccionID { get; set; }
        public int    referencia { get; set; }
        public String calle { get; set; }
        public String numero { get; set; }
        public String apartamento { get; set; }
        public int sectorID { get; set; }
        public String Coordenadas { get; set; }
        public bool Disponible { get; set; }
       }
}