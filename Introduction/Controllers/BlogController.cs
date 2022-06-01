using Introduction.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introduction.Controllers
{
    public class BlogController : Controller
    {

        private List<Blog> _blogs;
        public BlogController()
        {
            _blogs = new List<Blog>
            {
                new Blog(1,"Blog1","Content1","https://cdnb.artstation.com/p/assets/images/images/024/538/827/original/pixel-jeff-clipa-s.gif?1582740711"),
                new Blog(2,"Blog2","Content2","https://cdnb.artstation.com/p/assets/images/images/024/538/827/original/pixel-jeff-clipa-s.gif?1582740711"),
                new Blog(3,"Blog3","Content3","https://cdnb.artstation.com/p/assets/images/images/024/538/827/original/pixel-jeff-clipa-s.gif?1582740711"),
            };
        }
        public IActionResult Index()
        {
            ViewBag.Blogs = _blogs;
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Blog = _blogs.Find(x => x.Id == id);
            return View();
        }
    }
}
