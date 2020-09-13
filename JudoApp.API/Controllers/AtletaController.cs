
using System.Threading.Tasks;
using JudoApp.API.interfaces;
using Microsoft.AspNetCore.Mvc;
using JudoApp.API.Dtos;
namespace JudoApp.API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class AtletaController: ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AtletaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }

     /// <summary>
      /// Metodo que registra un nuevo usuario
      /// </summary>
      /// <param name="UserForRegisterDto"></param>
      /// <returns></returns>
       
      /*   [HttpPost("post")]
      public async Task<IActionResult> Register ( AtletaForRegisterDto Atleta)
        {
            await null;
           return StatusCode(201);

            
        }*/
}