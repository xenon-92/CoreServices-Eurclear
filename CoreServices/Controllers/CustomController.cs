using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CoreServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Post> AddPost()
        {
            BlogDBContext context = new BlogDBContext();
            Post p = new Post();
            p.Title = "Some kind of love";
            p.Description = "Namastey biscuit khao";
            p.CategoryId = 2;
            p.CreatedDate = DateTime.Now;
            context.Post.Add(p);
            context.SaveChanges();
            return p;
        }
    }
}