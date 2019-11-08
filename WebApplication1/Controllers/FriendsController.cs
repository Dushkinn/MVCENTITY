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
    public class FriendsController : Controller
    {

        private readonly DbTimeContext db;

        public FriendsController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<Friends> fr = await db.Friends.ToListAsync();
            return View(fr);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(Friends fr)
        {

            db.Friends.Add(fr);
            db.SaveChanges();
            List<Friends> friends = await db.Friends.ToListAsync();

            return View("Index", friends);

        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Friends fr)
        {

            db.Friends.Update(fr);
            db.SaveChanges();
            List<Friends> friends = await db.Friends.ToListAsync();
            return View("Index", fr);
        }




        public IActionResult Edit(int id)
        {
            Friends fr = db.Friends.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", fr);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.Friends.Remove(db.Friends.Where(u => u.id == id).First());
            db.SaveChanges();
            List<Friends> fr = await db.Friends.ToListAsync();
            return View("Index", fr);
        }


    }
}