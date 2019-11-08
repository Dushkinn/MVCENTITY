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
    public class StringFilesController : Controller
    {

        private readonly DbTimeContext db;

        public StringFilesController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<StringFiles> str = await db.StringFiles.ToListAsync();
            return View(str);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(StringFiles str)
        {

            db.StringFiles.Add(str);
            db.SaveChanges();
            List<StringFiles> strings = await db.StringFiles.ToListAsync();

            return View("Index", strings);

        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(StringFiles str)
        {

            db.StringFiles.Update(str);
            db.SaveChanges();
            List<StringFiles> strings = await db.StringFiles.ToListAsync();
            return View("Index", strings);
        }




        public IActionResult Edit(int id)
        {
            StringFiles str = db.StringFiles.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", str);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.StringFiles.Remove(db.StringFiles.Where(u => u.id == id).First());
            db.SaveChanges();
            List<StringFiles> strings = await db.StringFiles.ToListAsync();
            return View("Index", strings);
        }


    }
}