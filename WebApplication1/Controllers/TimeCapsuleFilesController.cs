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
    public class TimeCapsuleFilesController : Controller
    {

        private readonly DbTimeContext db;

        public TimeCapsuleFilesController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<TimeCapsuleFiles> tm = await db.TimeCapsuleFiles.ToListAsync();
            return View(tm);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(TimeCapsuleFiles tm)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            db.TimeCapsuleFiles.Add(tm);
            db.SaveChanges();
            List<TimeCapsuleFiles> timf = await db.TimeCapsuleFiles.ToListAsync();

            return View("Index", timf);

        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(TimeCapsuleFiles tm)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            db.TimeCapsuleFiles.Update(tm);
            db.SaveChanges();
            List<TimeCapsuleFiles> tim = await db.TimeCapsuleFiles.ToListAsync();
            return View("Index", tim);
        }




        public IActionResult Edit(int id)
        {
            TimeCapsuleFiles tm = db.TimeCapsuleFiles.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", tm);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.TimeCapsuleFiles.Remove(db.TimeCapsuleFiles.Where(u => u.id == id).First());
            db.SaveChanges();
            List<TimeCapsuleFiles> tm = await db.TimeCapsuleFiles.ToListAsync();
            return View("Index", tm);
        }


    }
}