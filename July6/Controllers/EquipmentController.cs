using July6.DTOs;
using July6.Models;
using July6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace July6.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService equipmentService;

        public EquipmentController(IEquipmentService serviceFromOutside )
        {
            equipmentService = serviceFromOutside;
        }

        [HttpGet("list")]
        public IActionResult GetAllEquipments ()
        {
            return Ok(equipmentService.GetEquipments());
        }
        [HttpPost("add")]
        //just temporarily returning the internal values for check!
        public IActionResult AddNewModel ( [FromBody] EquipmentCreateDTO userModelDTO)
        {   
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = equipmentService.AddNewEquipment( userModelDTO );
            if(result == true )
            {
                return Ok( new
                {
                    Message = $"The model {userModelDTO.ModelName} was added to the list" ,
                } );
            }
            return BadRequest();
        }
    }
}
