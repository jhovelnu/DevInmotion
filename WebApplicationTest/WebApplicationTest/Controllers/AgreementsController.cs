using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgreementService;
using AgreementService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementsController : ControllerBase
    {
        private readonly IServices _services;

        public AgreementsController(IServices services)
        {
            _services = services;            
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<AgreementListModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAgreements()
        {
            var res = await _services.GetAgreements();
            return Ok(res);
        }

    }
}
