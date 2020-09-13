namespace JudoApp.API.interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using JudoApp.API.DAL;
    using JudoApp.API.Models;

    public interface IMiembroRepository:IGenericRepository<Miembro>
    {
       Task <String> generateMiembroID(Club club);
       Task <Guid> generatePersonaID();
    }
}