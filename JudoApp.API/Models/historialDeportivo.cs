namespace JudoApp.API.Models
{
    using System;
    public class historialDeportivo
    {
       public int   historialDeportivoID {get;set;}
       public int atletaID {get;set;} 
       public DateTime fecha { get; set; }
       public String nombre { get; set; }
       public virtual Direccion Direccion {get;set;}
       public int lugarObtenido { get; set; }
       public virtual estadistica astadistica {get;set;}
    }
}