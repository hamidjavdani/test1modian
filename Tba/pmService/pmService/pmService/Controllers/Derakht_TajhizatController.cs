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
using pmService.Data;
using pmService.Models;

namespace pmService.Controllers
{
    public class Derakht_TajhizatController : ApiController
    {
        private pmServiceContext db = new pmServiceContext();

        // GET: api/Derakht_Tajhizat
        [HttpGet]
        [Route("api/Derakht_Tajhizat/GetDerakht_Tajhizat")]
        public IQueryable<Tbl_Derakht_Tajhizat> GetTbl_Derakht_Tajhizat()
        {
            //JToken json = JToken.Parse(JsonConvert.SerializeObject(cls_BargiriPt));
            return db.Tbl_Derakht_Tajhizat;
        }

        // GET: api/Derakht_Tajhizat/5
        [ResponseType(typeof(Tbl_Derakht_Tajhizat))]
        public IHttpActionResult GetTbl_Derakht_Tajhizat(int id)
        {
            Tbl_Derakht_Tajhizat tbl_Derakht_Tajhizat = db.Tbl_Derakht_Tajhizat.Find(id);
            if (tbl_Derakht_Tajhizat == null)
            {
                return NotFound();
            }

            return Ok(tbl_Derakht_Tajhizat);
        }

        // PUT: api/Derakht_Tajhizat/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTbl_Derakht_Tajhizat(int id, Tbl_Derakht_Tajhizat tbl_Derakht_Tajhizat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_Derakht_Tajhizat.ID)
            {
                return BadRequest();
            }

            db.Entry(tbl_Derakht_Tajhizat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tbl_Derakht_TajhizatExists(id))
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

        // POST: api/Derakht_Tajhizat
        [ResponseType(typeof(Tbl_Derakht_Tajhizat))]
        public IHttpActionResult PostTbl_Derakht_Tajhizat(Tbl_Derakht_Tajhizat tbl_Derakht_Tajhizat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tbl_Derakht_Tajhizat.Add(tbl_Derakht_Tajhizat);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Tbl_Derakht_TajhizatExists(tbl_Derakht_Tajhizat.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_Derakht_Tajhizat.ID }, tbl_Derakht_Tajhizat);
        }

        // DELETE: api/Derakht_Tajhizat/5
        [ResponseType(typeof(Tbl_Derakht_Tajhizat))]
        public IHttpActionResult DeleteTbl_Derakht_Tajhizat(int id)
        {
            Tbl_Derakht_Tajhizat tbl_Derakht_Tajhizat = db.Tbl_Derakht_Tajhizat.Find(id);
            if (tbl_Derakht_Tajhizat == null)
            {
                return NotFound();
            }

            db.Tbl_Derakht_Tajhizat.Remove(tbl_Derakht_Tajhizat);
            db.SaveChanges();

            return Ok(tbl_Derakht_Tajhizat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Tbl_Derakht_TajhizatExists(int id)
        {
            return db.Tbl_Derakht_Tajhizat.Count(e => e.ID == id) > 0;
        }
    }
}