using Microsoft.AspNetCore.Mvc;
using Laboratorium_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorium_3.Controllers
{
    public class PostController : Controller
    {
        static readonly Dictionary<int, Post> _posts = new Dictionary<int, Post>();
        static int id = 1;

        public IActionResult Index()
        {
            return View(_posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post model)
        {
            if (ModelState.IsValid)
            {
                model.Id = id++;
                _posts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_posts[id]);
        }

        [HttpPost]
        public IActionResult Update(Post model)
        {
            if (ModelState.IsValid)
            {
                _posts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_posts[id]);
        }

        [HttpPost]
        public IActionResult Delete(Post model)
        {
            _posts.Remove(model.Id);
            return RedirectToAction("Index");
        }
    }
}
