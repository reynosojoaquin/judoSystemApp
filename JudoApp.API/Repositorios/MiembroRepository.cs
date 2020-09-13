namespace JudoApp.API.Repositorios
{
    using JudoApp.API.Models;
    using JudoApp.API.interfaces;
    using JudoApp.API.DAL;
    using System.Threading.Tasks;
    using System;

    public class MiembroRepository:GenericRepository<Miembro>,IMiembroRepository
    {
          public MiembroRepository(judoAppDataContext context):base(context)
          {}

        public async Task<string> generateMiembroID(Club club)
        {
            string[] words = club.nombre.Split(' ');
            string codigo="";
            int indice = await  CountWhere(x=>x.club.ClubID == club.ClubID);
            foreach(string word in words)
            {
                codigo += word.Substring(0,1);
            }
            codigo +=  DateTime.Now.Year.ToString()+
            DateTime.Now.Month.ToString()+(indice+1).ToString();
           return await Task.Run(() =>
            {
                return codigo;
            });
        }

        public Task<Guid> generatePersonaID()
        {
            Guid personaID = Guid.NewGuid();
            
            return Task.Run(() =>
                {
                   return  personaID;
                }
            );

        }
    }
}