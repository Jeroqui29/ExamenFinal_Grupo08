using ExamenFinal_Grupo08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal_Grupo08.Controllers
{
    public class MeserosController : Controller
    {
        // GET: Meseros
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Meseros.ToList());
            }
        }

        // GET: Meseros/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Meseros.Where(x => x.ID_Mesero == id));
            }
        }

        // GET: Meseros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Meseros/Create
        [HttpPost]
        public ActionResult Create(Meseros meseros)
        {
            try
            {
                using (DbModels context = new DbModels()) 
                {
                    context.Meseros.Add(meseros);
                    context.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Meseros/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels()) 
            {
                return View(context.Meseros.Where(x => x.ID_Mesero == id).FirstOrDefault());
            }
        }

        // POST: Meseros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Meseros meseros)
        {
            try
            {
                using (DbModels context = new DbModels()) 
                {
                context.Entry(meseros).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Meseros/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels()) 
            {
                return View(context.Meseros.Where(x => x.ID_Mesero == id).FirstOrDefault());
            }
        }

        // POST: Meseros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Meseros meseros = context.Meseros.Where(x => x.ID_Mesero == id).FirstOrDefault();
                    context.Meseros.Remove(meseros);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
