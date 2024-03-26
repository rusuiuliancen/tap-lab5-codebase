using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IRepository<User> _userRepository;


        public UserController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet("get")]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetAll();
        }

        [HttpPost("add")]
        public void Add(UserDto userDto)
        {
            _userRepository.Add(new User(userDto.Name, userDto.Email, userDto.Password, userDto.TypeId));
            _userRepository.SaveChanges();
        }

        [HttpPut("update")]
        public void Update()
        {
            throw new NotImplementedException();
        }



        [HttpPut("delete")]
        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
