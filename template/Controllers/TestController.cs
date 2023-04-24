using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lomo_Template.Interfaces;


namespace Lomo_Template.Controllers
{
    [ApiController]
    //[Route("api/test")]
    public class TestController : ControllerBase
    {

        ITestService _testService;
        public TestController(ITestService testService)
        {
            this._testService = testService;
        }

        [Route("api/person/get")]
        [HttpGet]
        public IActionResult Get()
        {
            var res = _testService.GetPerson();
            return Ok(res);
        }
        [Route("api/address/get")]
        [HttpGet]
        public IActionResult GetAddress()
        {
            var res = _testService.GetAdress();
            return Ok(res);
        }
        [Route("api/address/getonlyadress")]
        [HttpGet]
        public IActionResult GetOnlyAddress()
        {
            var res = _testService.GetOnlyAddress();
            return Ok(res);
        }
        [Route("api/address/getadresspeople")]
        [HttpGet]
        public IActionResult GetAdressPeople()
        {
            var res = _testService.GetAdressPeople();
            return Ok(res);
        }

        [Route("api/people/getpeopleadress")]
        [HttpGet]
        public IActionResult GetPeopleAdress()
        {
            var res = _testService.GetPeopleAdress();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var res = _testService.GetPersonById(id);
            return Ok(res);
        }

        [Route("api/person/create")]
        [HttpPost]
        public IActionResult Post([FromBody] object body)
        {
            var res = _testService.CreatePerson(body);
            return Ok(res);
        }
        [Route("api/adress/create")]
        [HttpPost]
        public IActionResult PostAddress([FromBody] object body)
        {
            var res = _testService.CreateAddress(body);
            return Ok(res);
        }
    }
}
