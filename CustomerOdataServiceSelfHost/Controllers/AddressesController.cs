//-----------------------------------------------------------------------
// <copyright file="AddressesController.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace CustomerOdataServiceSelfHost.Controllers
{
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Web.Http;
    using System.Web.OData;
    using CustomerDatabase;
    using CustomerDatabase.Model;

    /// <summary>
    /// Customer address web controller
    /// </summary>
    public class AddressesController : ODataController
    {
        /// <summary>
        /// Entity framework db object
        /// </summary>
        private EntityDbContext db = new EntityDbContext();

        /// <summary>
        /// GET: ODataAddresses
        /// </summary>
        /// <returns>Requested EF entity object form database</returns>
        [EnableQuery]
        public IQueryable<Address> GetAddresses()
        {
            return this.db.Address;
        }

        /// <summary>
        /// GET: ODataAddresses(5)
        /// </summary>
        /// <param name="key">address key</param>
        /// <returns>Requested EF entity object form database</returns>
        [EnableQuery]
        public SingleResult<Address> GetAddress([FromODataUri] int key)
        {
            return SingleResult.Create(this.db.Address.Where(address => address.Id == key));
        }

        /// <summary>
        /// PUT: ODataAddresses(5)
        /// </summary>
        /// <param name="key">address key</param>
        /// <param name="patch">delta of changes</param>
        /// <returns>HTTP response</returns>
        public IHttpActionResult Put([FromODataUri] int key, Delta<Address> patch)
        {
            this.Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            Address address = this.db.Address.Find(key);
            if (address == null)
            {
                return this.NotFound();
            }

            patch.Put(address);

            try
            {
                this.db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.AddressExists(key))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.Updated(address);
        }

        /// <summary>
        /// POST: ODataAddresses
        /// </summary>
        /// <param name="address">address to post</param>
        /// <returns>HTTP response</returns>
        public IHttpActionResult Post(Address address)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.db.Address.Add(address);
            this.db.SaveChanges();

            return this.Created(address);
        }

        /// <summary>
        /// PATCH: ODataAddresses(5)
        /// </summary>
        /// <param name="key">Address key</param>
        /// <param name="patch">delta of changes</param>
        /// <returns>HTTP response</returns>
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Address> patch)
        {
            this.Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            Address address = this.db.Address.Find(key);
            if (address == null)
            {
                return this.NotFound();
            }

            patch.Patch(address);

            try
            {
                this.db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.AddressExists(key))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.Updated(address);
        }

        /// <summary>
        /// DELETE: ODataAddresses(5)
        /// </summary>
        /// <param name="key">Address key</param>
        /// <returns>HTTP response</returns>
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Address address = this.db.Address.Find(key);
            if (address == null)
            {
                return this.NotFound();
            }

            this.db.Address.Remove(address);
            this.db.SaveChanges();

            return this.StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// GET: ODataAddresses(5)/Customer
        /// </summary>
        /// <param name="key">address key</param>
        /// <returns>Requested customers</returns>
        [EnableQuery]
        public SingleResult<Customer> GetCustomer([FromODataUri] int key)
        {
            return SingleResult.Create(this.db.Address.Where(m => m.Id == key).Select(m => m.Customer));
        }

        /// <summary>
        /// IDisposable implementation
        /// </summary>
        /// <param name="disposing">True if disposing</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Check if address exist
        /// </summary>
        /// <param name="key">Address key</param>
        /// <returns>True if exist</returns>
        private bool AddressExists(int key)
        {
            return this.db.Address.Count(e => e.Id == key) > 0;
        }
    }
}
