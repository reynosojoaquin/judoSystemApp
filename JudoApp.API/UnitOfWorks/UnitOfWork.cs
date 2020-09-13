namespace JudoApp.API.UnitOfWorks
{
    using JudoApp.API.DAL;
    using JudoApp.API.interfaces;
    using JudoApp.API.Repositorios;
    
    public class UnitOfWork : IUnitOfWork
    {
      
        private readonly judoAppDataContext _context;
        public IAtletaRepository  Atleta   {get; private set;}
        public IMiembroRepository Miembro  {get;private set;}
        public UnitOfWork(judoAppDataContext context)
        {
            _context = context;
             Atleta  = new AtletaRepository(_context);
             Miembro = new MiembroRepository(_context);
        }
       
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void CreateTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }
    }
}