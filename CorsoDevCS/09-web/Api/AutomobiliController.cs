using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Esercizio_03;

namespace _09_web.Api
{
    public class AutomobiliController : ApiController
    {
        private AutoDb db = new AutoDb();

        // GET: api/Automobili
        public IQueryable<Automobile> GetAutomobili()
        {
            return db.Automobili;
        }

        // GET: api/Automobili/5
        [ResponseType(typeof(Automobile))]
        public IHttpActionResult GetAutomobile(int id)
        {
            Automobile automobile = db.Automobili.Find(id);
            if (automobile == null)
            {
                return NotFound();
            }

            return Ok(automobile);
        }

        // PUT: api/Automobili/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAutomobile(int id, Automobile automobile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != automobile.IdAutomobile)
            {
                return BadRequest();
            }

            db.Entry(automobile).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomobileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Automobili
        [ResponseType(typeof(Automobile))]
        public IHttpActionResult PostAutomobile(Automobile automobile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Automobili.Add(automobile);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = automobile.IdAutomobile }, automobile);
        }

        // DELETE: api/Automobili/5
        [ResponseType(typeof(Automobile))]
        public IHttpActionResult DeleteAutomobile(int id)
        {
            Automobile automobile = db.Automobili.Find(id);
            if (automobile == null)
            {
                return NotFound();
            }

            db.Automobili.Remove(automobile);
            db.SaveChanges();

            return Ok(automobile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutomobileExists(int id)
        {
            return db.Automobili.Count(e => e.IdAutomobile == id) > 0;
        }
    }
}