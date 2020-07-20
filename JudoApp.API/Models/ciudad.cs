namespace JudoApp.API.Models
{
    using System;
    public class ciudad
    {
        
         public int ciudadID { get; set; }
         public int provinciaID { get; set; }
         public String Descripcion { get; set; }
         public virtual sector Sector {get;set;}
    }
}