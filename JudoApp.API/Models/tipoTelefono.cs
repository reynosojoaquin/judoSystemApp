namespace JudoApp.API.Models
{ 
    using System;
     using System.ComponentModel.DataAnnotations;
    public class tipoTelefono
    {
       [Key]
       public int tipoTelefonoID { get; set; }  
       public String Descripcion  { get; set; }
    }
}