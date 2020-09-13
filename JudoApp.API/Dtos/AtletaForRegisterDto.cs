using JudoApp.API.Models;

namespace JudoApp.API.Dtos
{
    public class AtletaForRegisterDto
    {
        public int atletaID { get; set; }
        public int personaID { get; set; }
        public bool activo { get; set; }
    }
}