using create_api.Models;
using Microsoft.AspNetCore.Http;    
using Microsoft.AspNetCore.Mvc;

namespace create_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Usercontext usercontext;
        public UsersController(Usercontext usercontext)

        {
            this.usercontext = usercontext;
            
        }
        [HttpGet]
        [Route("GetUsers")]
        public List<Users> GetUsers()
        {
            return usercontext.Users.ToList();
        }
        [HttpPost]
        [Route("AddUser")]
        public String AddUser(Users users)
        {
            string response = string.Empty;
            usercontext.Users.Add(users);
            usercontext.SaveChanges();

            return "User Added";
        }
    }
}
