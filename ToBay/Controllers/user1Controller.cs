using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToBay.Models;
using System.Security.Cryptography;
using System.Text;

namespace ToBay.Controllers
{
    public class user1Controller : Controller
    {
        private project001Entities db = new project001Entities();

        // GET: user1
        public async Task<ActionResult> Index()
        {
            return View(await db.user1.ToListAsync());
        }

        // GET: user1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user1 user1 = await db.user1.FindAsync(id);
            if (user1 == null)
            {
                return HttpNotFound();
            }
            return View(user1);
        }

        // GET: user1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: user1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(string password, [Bind(Include = "username,password,name,pername,userId")] user1 user1)
        {
            if (ModelState.IsValid)
            {
                db.user1.Add(user1);
                string providedPasswordHash = HashPassword(password);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(user1);
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // GET: user1/Edit/5
        public async Task<ActionResult> Edit ( string password, int? id)
        {
            string providedPasswordHash = HashPassword(password);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user1 user1 = await db.user1.FindAsync(id);
            if (user1 == null)
            {
                return HttpNotFound();
            }
            return View(user1);
        }

        // POST: user1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "username,password,name,pername,userId")] user1 user1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user1).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user1);
        }

        // GET: user1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user1 user1 = await db.user1.FindAsync(id);
            if (user1 == null)
            {
                return HttpNotFound();
            }
            return View(user1);
        }

        // POST: user1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            user1 user1 = await db.user1.FindAsync(id);
            db.user1.Remove(user1);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
