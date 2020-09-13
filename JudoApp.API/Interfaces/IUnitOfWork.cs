namespace JudoApp.API.interfaces
{
   using System;
    using JudoApp.API.interfaces;

    public interface IUnitOfWork : IDisposable 
    {
         IAtletaRepository  Atleta  { get; }
         IMiembroRepository Miembro {get;}
          void CreateTransaction();
         void Commit();
         void Rollback();
         int Complete();
         
    }
}