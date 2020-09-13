namespace JudoApp.API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class estadistica
    {
        [Key]
        public int estadisticaID { get; set; }
        public int historialDeportivoID { get; set; }
        public int combateID { get; set; }
        public int evantoID { get; set; }
        public DateTime tiempo { get; set; }
        public int puntuacion { get; set; }
        public int evantoTipoID { get; set; }
        public String  descripcion { get; set; }

    }
}