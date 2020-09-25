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
using esercizio_04.Models;
using log4net;

namespace esercizio_04.Api
{
    public class OrdiniController : ApiController
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ECommerce db = new ECommerce();

        // GET: api/Ordini
        public IQueryable<Ordine> GetOrdini()
        {
            log.Debug($"elenco cordini");
            return db.Ordini;
        }

        // GET: api/Ordini
        public IQueryable<Ordine> GetOrdiniByDate(DateTime dataRif)
        {
            log.Debug($"elenco cordini");
            return db.Ordini.Where(o => o.DataOrdine == dataRif);
        }

        // GET: api/Ordini
        // [Route("a/b/c/lkdsfklshdl")]
        public IQueryable<Ordine> GetOrdiniByDateAndNumProducts(DateTime dataRif, int numRighe)
        {
            log.Debug($"elenco cordini");
            return db.Ordini.Where(o => o.DataOrdine == dataRif && o.RigheOrdine.Count > numRighe);
        }

        // GET: api/Ordini/5
        [ResponseType(typeof(Ordine))]
        public IHttpActionResult GetOrdine(int id)
        {
            log.Debug($"recupero ordine num {id}");
            Ordine ordine = db.Ordini.Find(id);
            if (ordine == null)
            {
                return NotFound();
            }

            return Ok(ordine);
        }

        // PUT: api/Ordini/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrdine(int id, Ordine ordine)
        {
            log.Debug($"update dell'ordine num. {id}");
            if (!ModelState.IsValid)
            {
                log.Warn($"modello ordine non valido");
                return BadRequest(ModelState);
            }

            if (id != ordine.NumeroOrdine)
            {
                log.Warn($"id ordine non coincidente {id} != {ordine.NumeroOrdine}");
                return BadRequest();
            }

            db.Entry(ordine).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
                log.Info($"ordine num. {id} salvato");
            }
            catch (DbUpdateConcurrencyException e)
            {
                log.Error($"eccezione salvando ordine num. {id}", e);
                if (!OrdineExists(id))
                {
                    log.Warn($"l'ordine num. {id} non esiste");
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Ordini
        [ResponseType(typeof(Ordine))]
        public IHttpActionResult PostOrdine(Ordine ordine)
        {
            log.Debug($"inserimento nuovo ordine");
            if (!ModelState.IsValid)
            {
                log.Warn($"modello ordine non valido");
                return BadRequest(ModelState);
            }

            db.Ordini.Add(ordine);
            db.SaveChanges();
            log.Info($"nuovo ordine num. {ordine.NumeroOrdine} salvato");

            return CreatedAtRoute("DefaultApi", new { id = ordine.NumeroOrdine }, ordine);
        }

        // DELETE: api/Ordini/5
        [ResponseType(typeof(Ordine))]
        public IHttpActionResult DeleteOrdine(int id)
        {
            log.Debug($"cancellazione ordine num. {id}");
            Ordine ordine = db.Ordini.Find(id);
            if (ordine == null)
            {
                log.Warn($"l'ordine num. {id} non esiste");
                return NotFound();
            }

            db.Ordini.Remove(ordine);
            db.SaveChanges();
            log.Info($"ordine num. {id} cancellato");

            return Ok(ordine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrdineExists(int id)
        {
            return db.Ordini.Count(e => e.NumeroOrdine == id) > 0;
        }
    }
}