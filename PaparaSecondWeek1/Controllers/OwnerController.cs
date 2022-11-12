using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaSecondWeek1.Attributes;
using PaparaSecondWeek1.Models;
using PaparaSecondWeek1.Services;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {

            _ownerService = ownerService;
        }

        [HttpPost("Create")]
        [ValidateModelState]
        public IActionResult Post()
        {
            var result = _ownerService.Add();
            return Ok(result);
        }

        [HttpGet("GetOwner")]
        public IActionResult Get()
        {
            var result = _ownerService.Get();
            return Ok(result);
        }

        [HttpDelete("DeleteOwner")]
        public IActionResult Delete()
        {
            var result = _ownerService.Delete();
            return Ok(result);
        }

        [HttpGet("GetOwnerProperties")]
        public IActionResult GetOwnerProperties()
        {
            OwnerModel owner = new OwnerModel();
            var result = new List<string>();
            var properties = owner.GetType().GetProperties().ToArray();
            foreach (var item in properties)
            {
                result.Add(item.Name);
            }
            return Ok(result);
        }


    }
}
