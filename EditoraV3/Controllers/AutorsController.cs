﻿using EditoraV3.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace EditoraV3.Controllers
{
    public class AutorsController : ApiController
    {
        private MyDbContext db = new MyDbContext();

        // GET: api/Autors
        public IQueryable<Autor> Getautors()
        {
            return db.autors;

        }

        // GET: api/Autors/5
        [ResponseType(typeof(Autor))]
        public IHttpActionResult GetAutor(int id)
        {
            //var headers = Request.Headers;
            //if(headers.Contains("jwt"))
            Autor autor = db.autors.Find(id);
            if (autor == null)
            {
                return NotFound();
            }

            return Ok(autor);
        }

        // PUT: api/Autors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAutor(int id, Autor autor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != autor.ID_Autor)
            {
                return BadRequest();
            }

            db.Entry(autor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutorExists(id))
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

        // POST: api/Autors
        [ResponseType(typeof(Autor))]
        public IHttpActionResult PostAutor(Autor autor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.autors.Add(autor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = autor.ID_Autor }, autor);
        }

        // DELETE: api/Autors/5
        [ResponseType(typeof(Autor))]
        public IHttpActionResult DeleteAutor(int id)
        {
            Autor autor = db.autors.Find(id);
            if (autor == null)
            {
                return NotFound();
            }

            db.autors.Remove(autor);
            db.SaveChanges();

            return Ok(autor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutorExists(int id)
        {
            return db.autors.Count(e => e.ID_Autor == id) > 0;
        }
    }
}