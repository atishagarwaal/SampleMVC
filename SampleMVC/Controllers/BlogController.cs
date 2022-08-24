using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleMVC.Models;
using Microsoft.AspNetCore.Authorization;
using SampleMVC.Data;

namespace SampleMVC.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        public readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var list = _db.Posts.ToArray();
            return View(list);
        }

        [AllowAnonymous]
        [Route("{Year}/{Month}/{Title}")]
        public IActionResult Post(int Year, int Month, string Title)
        {
            var post = _db.Posts.FirstOrDefault(i => i.Posted.Year == Year &&
                                                     i.Posted.Month == Month &&
                                                     i.Title == Title);
            return View(post);
        }

        //[Authorize]
        [HttpGet, Route("create")]
        public IActionResult Create()
        { 
            return View();
        }

        //[Authorize]
        [HttpPost, Route("create")]
        public IActionResult CreatePost(Post post)
        {
            if (!ModelState.IsValid)
                return View();

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();

            //send mail
            //_emailSender.SendEmailAsync("aatishagarwal@gmail.com", "New Blog Post", $"New blog named \"{post.Title}\"  has been created.");

            return RedirectToAction("Post", "Blog", new { 
            
                Year = post.Posted.Year,
                Month = post.Posted.Month,
                Title = post.Title

            });
        }
    }
}
