using Apideneme.Data;
using Apideneme.Dtos;
using Apideneme.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Apideneme.Controllers
{
    [Route("Apideneme/user")]
    public class UserController : ControllerBase
    {
        private readonly ContactsAPIDbContext _context;

        public UserController(ContactsAPIDbContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult GetAll() { 
        
            var contacts = _context.Contacts.ToList()
                .Select(s => s.ToContactdto());


            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) {
            var user = _context.Contacts.Find(id);

            if (user == null) { 
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDto contactdto)
        {
            var userModel = contactdto.ToNewUserdto();
            _context.Contacts.Add(userModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = userModel.Id },userModel.ToContactdto());
        }
    }

}
