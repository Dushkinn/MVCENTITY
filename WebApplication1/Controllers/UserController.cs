using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {

        private readonly DbTimeContext db;

        public UserController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<User> users = await db.User.ToListAsync();
            return View(users);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
                db.User.Add(user);
                db.SaveChanges();
             
            
            List<User> users = await db.User.ToListAsync();

            return View("Index", users);
        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            db.User.Update(user);
            db.SaveChanges();
            List<User> users = await db.User.ToListAsync();
            return View("Index", users);
        }




        public IActionResult Edit(int id)
        {
            User user = db.User.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", user);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.User.Remove(db.User.Where(u => u.id == id).First());
            db.SaveChanges();
            List<User> users = await db.User.ToListAsync();
            return View("Index", users);
        }

        [HttpPost]
        public JsonResult IsAlreadySigned(string login)
        {

            return Json(IsUserAvailable(login));

        }
        public bool IsUserAvailable(string login)
        {

            var userLogin = db.User.Where(u => u.login == login).FirstOrDefault();

            bool status;
            if (userLogin != null)
            {
                //Already registered  
                status = false;
            }
            else
            {
                //Available to use  
                status = true;
            }


            return status;
        }


    }
}