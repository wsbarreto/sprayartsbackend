using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sprayartsbackend.Domain.Account;
using sprayartsbackend.Web.ViewModels;

namespace sprayartsbackend.Web.Controllers { 

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserStorer _userStorer;
        public UserController(UserStorer userStorer)
        {
            _userStorer = userStorer;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var users = _userStorer.GetUsers();

            var viewModel = users.Select(a => new UserViewModel
            {
                Id = a.Id,
                UserName = a.UserName,
                Email = a.Email,

            });

            return Ok(viewModel);
        }

        //[HttpGet]
        //public ActionResult<string> GetPredicate(Func<UserViewModel, bool> predicate)
        //{            
        //    var user = _userStorer.GetUser(predicate);


        //    return user.;
        //}
    }
}