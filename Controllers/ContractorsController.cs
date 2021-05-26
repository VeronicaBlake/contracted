using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorsController : ControllerBase
    {
        private readonly ContractorsService _contractorsService;

        public ContractorsController(ContractorsService cs)
        {
            _contractorsService = cs;
        }

        [HttpGet]
        public ActionResult<List<Contractor>> GetAll()
        {
            try
            {
                List<Contractor> contractors = _contractorsService.GetAll();
                return Ok(contractors);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        public ActionResult<List<Contractor>> GetOne()
        {
            try
            {
                List<Contractor> contractors = _contractorsService.GetOne();
                return Ok(contractors);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<List<Contractor>> Create()
        {
            try
            {
                List<Contractor> contractors = _contractorsService.Create();
                return Ok(contractors);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public ActionResult<List<Contractor>> Update()
        {
            try
            {
                List<Contractor> contractors = _contractorsService.Update();
                return Ok(contractors);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult<List<Contractor>> Delete()
        {
            try
            {
                List<Contractor> contractors = _contractorsService.Delete();
                return Ok(contractors);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}