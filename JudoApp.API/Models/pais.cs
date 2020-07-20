namespace JudoApp.API.Models
{
    using System;
    public class pais
    {
         public int paisID { get; set; }
         public String Descripcion { get; set; }
         public virtual provincia Provincia {get;set;}
    }
}