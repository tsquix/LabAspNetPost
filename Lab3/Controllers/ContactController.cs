﻿using Microsoft.AspNetCore.Mvc;

using System.Reflection;
using Labolatorium_3.Models;

namespace Labolatorium_3.Controllers
{
    public class ContactController : Controller
    {
        //static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        //static int id = 1;
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.Delete(model.Id);
            return RedirectToAction("Index");
        }
    } 
}
 