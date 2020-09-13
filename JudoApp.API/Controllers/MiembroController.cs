using JudoApp.API.interfaces;
using JudoApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using JudoApp.API.Dtos;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JudoApp.API.Controllers
{
  /// <summary>
  /// 
  /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MiembroController: ControllerBase
    {
      /// <summary>
      /// 
      /// </summary>
         private readonly IUnitOfWork _unitOfWork;
        public    MiembroController(IUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// tarea que registra un nuevo miembro del club
        /// </summary>
        /// <param name="miembro"></param>
        /// <returns></returns>
        [HttpPost("/api/miembro/addMember")]
        public async Task<IActionResult> addMember(miembroForRegisterDto miembro)
        {

             var _miembro = new Miembro();
            if(ModelState.IsValid)
            {
                try
                {
                  _unitOfWork.CreateTransaction();
                     _miembro = new Miembro 
                    {
                            referencia = await _unitOfWork.Miembro.generateMiembroID(miembro.Club), 
                            personaID = await _unitOfWork.Miembro.generatePersonaID(),
                            club    =  miembro.Club,
                            nombre    =  miembro.nombre,
                            apellido  = miembro.apellido,
                            fechaNacimiento = miembro.fechaNacimiento,
                            fechaIngredo    = DateTime.Now,
                            sexo            = miembro.sexo,
                            Telefono        = miembro.Telefono,
                            correoElectronico = miembro.correoElectronico,
                            Direccion          = miembro.Direccion,
                            activo             = true, 
                            contacto           = miembro.contacto, 
                            HistoriaClinica    = miembro.HistoriaClinica,
                            cedula             = miembro.cedula,
                            folio              = miembro.folio,  
                            circunscripcion    = miembro.circunscripcion, 
                            nivelEducativo     = miembro.nivelEducativo
                    };                   
                 await   _unitOfWork.Miembro.Add(_miembro);
                        _unitOfWork.Complete();
                        _unitOfWork.Commit();
                
                }catch(Exception e)
                {
                  _unitOfWork.Rollback();
                  return BadRequest(e);   
                }
               
            }
              return Ok(_miembro.miembroID);
        }
        /// <summary>
        ///  metodo que devuelve todos los miembros de registrdos
        /// </summary>
       /// <returns>lista de miembros</returns>
        [HttpGet("/api/miembro")]
        public async Task<IActionResult> GetMembers()
        {
              var values = await _unitOfWork.Miembro.GetAll();
             return   Ok(values);                
        }
        /// <summary>
        /// procedimiento para desabilitar un miembro
        /// </summary>
        /// <param name="miembro"></param>
        /// <returns></returns>
      [HttpDelete("/api/miembro/DesableMember/{id}")]
      public async Task<IActionResult> DesableMember(String ID)
      {
         _unitOfWork.CreateTransaction();
         try{
           Miembro currentMember = new Miembro();
           currentMember = await  _unitOfWork.Miembro.GetById( Convert.ToInt32(ID));
           currentMember.activo = false;
          await _unitOfWork.Miembro.Update(currentMember);
        
         }catch(Exception)
         {
           _unitOfWork.Rollback();
         }  
          _unitOfWork.Complete();
          _unitOfWork.Commit();
          return Ok(ID);
      }
      /// <summary>
      /// procedimiento para actualizar un miembro
      /// </summary>
      /// <param name="ID"></param>
      /// <param name="miembro"></param>
      /// <returns>ID</returns>
      [HttpPut("/api/miembro/UpdateMember")]
      public async Task<IActionResult>UpdateMember( Miembro miembro)
      {
          _unitOfWork.CreateTransaction();
         try
         {
           await _unitOfWork.Miembro.Update(miembro);
          _unitOfWork.Complete();
          _unitOfWork.Commit();
         }catch(Exception)
         {
           _unitOfWork.Rollback();
         }
          return Ok(miembro);
      }
     
     /// <summary>
     /// procedimiento que devuelve un miembro por medido del ID
     /// </summary>
     /// <param name="id"></param>
     /// <returns>Miembro</returns>
      [HttpGet("/api/miembro/GetMemberByID/{id}")]
      public async Task<ActionResult<Miembro>>GetMemberByID(string id)
      {
         Miembro currentMember = await _unitOfWork.Miembro.GetById(Convert.ToInt32(id));
         if(currentMember == null)
         {
           return NotFound(id);
         }
         return currentMember;

      }
    
    }
}