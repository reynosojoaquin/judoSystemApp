namespace JudoApp.API.Models
{
    public class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Passwordkey   {get;set;}
    }
}