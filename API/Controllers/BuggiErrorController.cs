using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggiErrorController : BaseController
    {
        private readonly WomContext _context;
        public BuggiErrorController(WomContext context)
        {
            _context = context;
        }

        //401
        [HttpGet("notFound")]
        public ActionResult GetNotFoundRecuest()
        {
            var obj = _context.Consumers.Find(33);
            if(obj == null)
            {
                return NotFound(new ApiResponse(404));       
            }
            return Ok(obj);
            
        }

        //500
        [HttpGet("serverError")]
        public ActionResult GetServerErrorRequest()
        {
            var obj = _context.Consumers.Find(33);

            var obj_ = obj.ToString();

            return Ok();
            
        }
        //201
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest();
            
        }

        [HttpGet("badrequest/{id}")]
        public ActionResult GetGetNotFoundRequest(int id)
        {
            return Ok();
            
        }

    }
}