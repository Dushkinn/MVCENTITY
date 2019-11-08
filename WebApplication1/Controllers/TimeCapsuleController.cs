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
    public class TimeCapsuleController : Controller
    {

        private readonly DbTimeContext db;

        public TimeCapsuleController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<TimeCapsuleController> tc = await db.TimeCapsule.ToListAsync();
            return View(tc);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(TimeCapsule tc)
        {

            db.TimeCapsule.Add(tc);
            db.SaveChanges();
            List<TimeCapsule> timecapsules = await db.TimeCapsule.ToListAsync();

            return View("Index", timecapsules);

        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(TimeCapsule tm)
        {

            db.TimeCapsule.Update(tm);
            db.SaveChanges();
            List<TimeCapsule> tmCapsule = await db.TimeCapsule.ToListAsync();
            return View("Index", tmCapsule);
        }




        public IActionResult Edit(int id)
        {
            TimeCapsule tc = db.TimeCapsule.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", tc);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.TimeCapsule.Remove(db.TimeCapsule.Where(u => u.id == id).First());
            db.SaveChanges();
            List<TimeCapsule> tc = await db.TimeCapsule.ToListAsync();
            return View("Index", tc);
        }


    }
}