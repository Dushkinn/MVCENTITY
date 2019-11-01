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
            List<User> users =await db.User.ToListAsync();
            return View(users);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(User user)
        {

                db.User.Add(user);
                db.SaveChanges();
                List<User> users = await db.User.ToListAsync();

                return View("Index",users);
        
        }

       

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(User user)
        {

            db.User.Update(user);
            db.SaveChanges();
            List<User> users = await db.User.ToListAsync();
            return View("Index", users);
        }




        public IActionResult Edit()
        {
          return View("Edit");
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.User.Remove(db.User.Where(u => u.id == id).First());
            db.SaveChanges();
            List<User> users = await db.User.ToListAsync();
            return View("Index", users);
        }

    
    }
}