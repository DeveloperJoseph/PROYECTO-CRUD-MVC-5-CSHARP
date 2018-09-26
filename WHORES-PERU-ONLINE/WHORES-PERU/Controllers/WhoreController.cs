using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WHORES_PERU.Context;
using WHORES_PERU.Models;

namespace WHORES_PERU.Controllers
{
    public class WhoreController : Controller
    {
        //ACCESO AL BASE DE DATOS
        private WhoreContext db = new WhoreContext(); 
        
        // GET: Whore
        public ActionResult Index()
        {
            return View(db.Whores.ToList());
        }

        // GET: Whore/Details/5
        public ActionResult Details(int? id)
        {
            // INSERTADO METODO FIND A NUESTRO CONTROLADOR
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var whore = db.Whores.Find(id);

            if (whore == null)
            {
                return HttpNotFound();
            }
            return View(whore);
        }

        // GET: Whore/Create
       [HttpGet]//añadiendo metodo http get 
        public ActionResult Create()
        {
            return View();
        }

        // POST: Whore/Create
        [HttpPost]
        public ActionResult Create(Whore whore)
        {
            try
            {
                // INSERTADO METODO ADD A NUESTRO CONTROLADOR
                if (ModelState.IsValid)
                {
                    db.Whores.Add(whore);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(whore);
            }
            catch
            {
                return View(whore);
            }
        }

        // GET: Whore/Edit/5
        public ActionResult Edit(int? id)
        {
            //TODO CODIGO PARA EDITAR
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var whore = db.Whores.Find(id);

            if(whore == null)
            {
                return HttpNotFound();
            }
            return View(whore);
        }

        // POST: Whore/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Whore whore)
        {
            try
            {
                //TODO CODIGO PARA EDITAR
                if(ModelState.IsValid)
                {
                    db.Entry(whore).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(whore);
            }
            catch{  
            
                return View(whore);
            }
        }

        // GET: Whore/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var whore = db.Whores.Find(id);
            if (whore == null)
            {
                return HttpNotFound();
            }
            return View(whore);
        }

        // POST: Whore/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Whore whore)
        {
            try
            {
                // TODO: Add delete logic here
                if(ModelState.IsValid)
                {
                    whore = db.Whores.Find(id);
                    if (whore == null)
                    {
                        return HttpNotFound();
                    }
                    db.Whores.Remove(whore);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(whore);
            }
            catch
            {
                return View(whore);
            }
        }
    }
}
