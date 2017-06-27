using EscaliTest.DataAccess;
using EscaliTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EscaliTest.Controllers
{
    public class SecurityController : ApiController
    {
        // GET: api/Security
        public IEnumerable<tblSecurity> Get()
        {
            using (var db = new EscaliDb())
            {
                return db.Securities.ToList();
            }
        }

        // GET: api/Security/5
        public tblSecurity Get(int id)
        {
            using (var db = new EscaliDb())
            {
                return db.Securities.Find(id);
            }
        }

        // POST: api/Security
        public void Post([FromBody]tblSecurity value)
        {
            using (var db = new EscaliDb())
            {
                db.Securities.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Security/5
        public void Put(int id, [FromBody]tblSecurity value)
        {
            using (var db = new EscaliDb())
            {
                db.Securities.Attach(value);
                db.SaveChanges();
            }
        }

        // DELETE: api/Security/5
        public void Delete(int id)
        {
            using (var db = new EscaliDb())
            {
                var toDelete = db.Securities.Find(id);
                db.Securities.Remove(toDelete);
                db.SaveChanges();
            }
        }
    }
}
