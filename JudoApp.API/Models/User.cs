namespace JudoApp.API.Models
{
     using System.ComponentModel.DataAnnotations;
    public class User
    {
        [Key]
        public int id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Passwordkey   {get;set;}
    }
}