using ExamenFinal_Grupo08.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal_Grupo08.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            using (DbModels context = new DbModels()) 
            {
            return View(context.Clientes.ToList());
            }
                
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels()) 
            {
                return View(context.Clientes.Where(x => x.ID_Cliente == id));
            }
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes clientes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Clientes.Add(clientes);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch

            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Clientes.Where(x => x.ID_Cliente == id).FirstOrDefault());
            }    
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Clientes clientes)
        {
            try
            {
                using (DbModels context = new DbModels()) 
                {
                    context.Entry(clientes).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Clientes.Where(x => x.ID_Cliente == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                using (DbModels context = new DbModels())
                {
                    Clientes clientes = context.Clientes.Where(x => x.ID_Cliente == id).FirstOrDefault();
                    context.Clientes.Remove(clientes);
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
