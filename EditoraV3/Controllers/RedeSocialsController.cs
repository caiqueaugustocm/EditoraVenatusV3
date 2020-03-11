﻿using EditoraV3.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace EditoraV3.Controllers
{
    public class RedeSocialsController : ApiController
    {
        private MyDbContext db = new MyDbContext();

        // GET: api/RedeSocials
        public IQueryable<RedeSocial> GetredeSocials()
        {
            return db.redeSocials;
        }

        // GET: api/RedeSocials/5
        [ResponseType(typeof(RedeSocial))]
        [Route("api/RedeSocials/GetRedeSocialByCLiente")]
        public IHttpActionResult GetRedeSocialByCLiente(int id)
        {
            var id_red = from red in db.redeSocials where red.Id_cli == id select red.ID_RedeSocial;
            RedeSocial redeSocial = db.redeSocials.Find(id_red.First());
            if (redeSocial == null)
            {
                return NotFound();
            }

            return Ok(redeSocial);
        }
        [ResponseType(typeof(RedeSocial))]
        [Route("api/RedeSocials/GetRedeSocialByAutor")]
        public IHttpActionResult GetRedeSocialByAutor(int id)
        {
            var id_red = from red in db.redeSocials where red.Id_aut == id select red.ID_RedeSocial;
            RedeSocial redeSocial = db.redeSocials.Find(id_red.First());
            if (redeSocial == null)
            {
                return NotFound();
            }

            return Ok(redeSocial);
        }
        // PUT: api/RedeSocials/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRedeSocial(int id, RedeSocial redeSocial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != redeSocial.ID_RedeSocial)
            {
                return BadRequest();
            }

            db.Entry(redeSocial).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RedeSocialExists(id))
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

        // POST: api/RedeSocials
        [ResponseType(typeof(RedeSocial))]
        public IHttpActionResult PostRedeSocial(RedeSocial redeSocial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.redeSocials.Add(redeSocial);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = redeSocial.ID_RedeSocial }, redeSocial);
        }

        // DELETE: api/RedeSocials/5
        [ResponseType(typeof(RedeSocial))]
        public IHttpActionResult DeleteRedeSocial(int id)
        {
            RedeSocial redeSocial = db.redeSocials.Find(id);
            if (redeSocial == null)
            {
                return NotFound();
            }

            db.redeSocials.Remove(redeSocial);
            db.SaveChanges();

            return Ok(redeSocial);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RedeSocialExists(int id)
        {
            return db.redeSocials.Count(e => e.ID_RedeSocial == id) > 0;
        }
    }
}