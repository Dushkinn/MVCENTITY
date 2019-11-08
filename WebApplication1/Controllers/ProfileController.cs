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
    public class ProfileController : Controller
    {

        private readonly DbTimeContext db;

        public ProfileController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<Profile> pr = await db.Profile.ToListAsync();
            return View(pr);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(Profile pr)
        {

            db.Profile.Add(pr);
            db.SaveChanges();
            List<Profile> profiles = await db.Profile.ToListAsync();

            return View("Index", profiles);

        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Profile profile)
        {

            db.Profile.Update(profile);
            db.SaveChanges();
            List<Profile> pr = await db.Profile.ToListAsync();
            return View("Index", pr);
        }




        public IActionResult Edit(int id)
        {
            Profile pr = db.Profile.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", pr);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.Profile.Remove(db.Profile.Where(u => u.id == id).First());
            db.SaveChanges();
            List<Profile> pr = await db.Profile.ToListAsync();
            return View("Index", pr);
        }


    }
}