﻿using ExamenFinal_Grupo08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal_Grupo08.Controllers
{
    public class PlatillosController : Controller
    {
        // GET: Platillos
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Platillos.ToList());
            }
        }

        // GET: Platillos/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Platillos.Where(x => x.ID_Platillo == id));
            }
        }

        // GET: Platillos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Platillos/Create
        [HttpPost]
        public ActionResult Create(Platillos platillos)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Platillos.Add(platillos);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Platillos/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Platillos.Where(x => x.ID_Platillo == id).FirstOrDefault());
            }
        }

        // POST: Platillos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Platillos platillos)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(platillos).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Platillos/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Platillos.Where(x => x.ID_Platillo == id).FirstOrDefault());
            }
        }

        // POST: Platillos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Platillos platillos = context.Platillos.Where(x => x.ID_Platillo == id).FirstOrDefault();
                    context.Platillos.Remove(platillos);
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
