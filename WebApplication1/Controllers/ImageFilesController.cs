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
    public class ImageFilesController : Controller
    {

        private readonly DbTimeContext db;

        public ImageFilesController(DbTimeContext dbContext)
        {
            db = dbContext;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<ImageFiles> users = await db.ImageFiles.ToListAsync();
            return View(users);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        public async Task<IActionResult> Add(ImageFiles img)
        {

            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            db.ImageFiles.Add(img);
            db.SaveChanges();
            List<ImageFiles> images = await db.ImageFiles.ToListAsync();

            return View("Index", images);

        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ImageFiles img)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            db.ImageFiles.Update(img);
            db.SaveChanges();
            List<ImageFiles> images = await db.ImageFiles.ToListAsync();
            return View("Index", images);
        }




        public IActionResult Edit(int id)
        {
            ImageFiles img = db.ImageFiles.Where(u => u.id == id).FirstOrDefault();

            return View("Edit", img);
        }



        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            db.ImageFiles.Remove(db.ImageFiles.Where(u => u.id == id).First());
            db.SaveChanges();
            List<ImageFiles> img = await db.ImageFiles.ToListAsync();
            return View("Index", img);
        }


    }
}