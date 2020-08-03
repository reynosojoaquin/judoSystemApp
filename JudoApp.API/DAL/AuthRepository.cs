using System.Threading.Tasks;
using JudoApp.API.DAL;
 using Microsoft.EntityFrameworkCore;
 using JudoApp.API.Models;
namespace JudoApp.API.DAL
{
    public class AuthRepository:IAuthRepository
    {
        private readonly judoAppDataContext _context;
        public AuthRepository(judoAppDataContext context)
        {
                _context = context;
        }
         public async Task<User>Register(User user,string password)
         {
            byte[] passwordKey,passwordHash;
            CreatePasswordHash(password,out  passwordHash,out  passwordKey);
            user.PasswordHash = passwordHash;
            user.Passwordkey  = passwordKey;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
         }
         private void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordKey){
                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    passwordKey  = hmac.Key;
                    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); 
                }
         }
         public async Task<User>Login(string username,string password)
         {
              var user = await _context.Users.FirstOrDefaultAsync(x=>x.UserName==username);
              if(user==null)
              {
                   return null; 
              }
              if(!VerifyPasswordHash(password,user.PasswordHash,user.Passwordkey))
                  return null;

              return user;
         }

         public bool VerifyPasswordHash(string password,byte[] passwordHash, byte[] passwordkey)
         {
             using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordkey))
             {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));                  
                for(int i = 0; i< computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }

             }
             return true;

         }
         public async Task<bool>UserExists(string username)
         {
             if(await _context.Users.AnyAsync(x => x.UserName == username))
                  return true;
             return false;
         }
    }
}