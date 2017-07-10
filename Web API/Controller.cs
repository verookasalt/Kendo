using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class MyController : ApiController
    {
        /// If you compare the method signatures in this class with
        /// those created by the Web API scaffolding, you will see
        /// the differences.
        ///
        /// The modifications are necessary for the object passed from the
        /// Telerik Kendo UI grid methods to function properly. 
        ///
        /// The default scaffolded methods will not work so modify your
        /// code below to work with Kendo UI.

        private EntityFrameworkDBContext db = new EntityFrameworkDBContext();

        // GET api/myobjects
        public IEnumerable<MyObject> GetMyObjects()
        {
            return db.MyObjects.AsEnumerable();
        }

        // Get api/myobjects/5
        public MyObject GetMyObject(int id)
        {
            var myObject = db.MyObjects.Find(id);
            if (myObject == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return myObject;
        }

        // PUT api/myobjects/  
        // The PUT command will be send along with the object
        // Compare this to the scaffolded version to see the difference.
        public HttpResponseMessage PutMyObject(MyObject myObject)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            db.Entry(myObject).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, myObjet);
        }

        // POST api/myobjects/  
        // The POST command will be send along with the object
        // Compare this to the scaffolded version to see the difference.
        public HttpResponseMessage PostMyObject(MyObject myObject)
        {
            if (ModelState.IsValid)
            {
                db.MyObjects.Add(myObject);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, myObject);
                response.Headers.Location = new System.Uri(Url.Link("DefaultApi", new { id = myObject.MyObjectId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/myobjects/  
        // The DELETE command will be send along with the object
        // Compare this to the scaffolded version to see the difference.
        public HttpResponseMessage DeleteMyObject(MyObject myObject)
        {
            var myObject1 = db.MyObjects.Find(myObject.MyObjectId);

            if (myObject1 == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.MyObjects.Remove(myObject1);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, myObject);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}