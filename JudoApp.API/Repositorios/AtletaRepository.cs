namespace JudoApp.API.Repositorios
{
    using JudoApp.API.Models;
    using JudoApp.API.interfaces;
    using JudoApp.API.DAL;
    public class AtletaRepository:GenericRepository<atleta>,IAtletaRepository
    {
        public AtletaRepository(judoAppDataContext context):base(context)
        {}
        
    }
} 