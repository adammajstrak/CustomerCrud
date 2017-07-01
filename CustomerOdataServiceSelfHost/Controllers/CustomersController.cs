//-----------------------------------------------------------------------
// <copyright file="CustomersController.cs" company="MySuperCompany">
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
    /// Customer controller
    /// </summary>
    public class CustomersController : ODataController
    {
        /// <summary>
        /// Entity framework db object
        /// </summary>
        private EntityDbContext db = new EntityDbContext();

        /// <summary>
        /// GET: ODataCustomers
        /// </summary>
        /// <returns>Requested EF entity object form database</returns>
        [EnableQuery]
        public IQueryable<Customer> GetCustomers()
        {
            return this.db.Customer;
        }

        /// <summary>
        /// GET: ODataCustomers(5)
        /// </summary>
        /// <param name="key">Customer key</param>
        /// <returns>Requested EF entity object form database</returns>
        [EnableQuery]
        public SingleResult<Customer> GetCustomer([FromODataUri] int key)
        {
            return SingleResult.Create(this.db.Customer.Where(customer => customer.Id == key));
        }

        /// <summary>
        /// PUT: ODataCustomers(5)
        /// </summary>
        /// <param name="key">Customer key</param>
        /// <param name="patch">Delta of changes</param>
        /// <returns>HTTP response</returns>
        public IHttpActionResult Put([FromODataUri] int key, Delta<Customer> patch)
        {
            this.Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            Customer customer = this.db.Customer.Find(key);
            if (customer == null)
            {
                return this.NotFound();
            }

            patch.Put(customer);

            try
            {
                this.db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.CustomerExists(key))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.Updated(customer);
        }

        /// <summary>
        /// POST: ODataCustomers
        /// </summary>
        /// <param name="customer">Customer to post</param>
        /// <returns>HTTP response</returns>
        public IHttpActionResult Post(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.db.Customer.Add(customer);
            this.db.SaveChanges();

            return this.Created(customer);
        }

        /// <summary>
        /// PATCH: ODataCustomers(5)
        /// </summary>
        /// <param name="key">Customer key</param>
        /// <param name="patch">Delta of changes</param>
        /// <returns>HTTP response</returns>
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Customer> patch)
        {
            this.Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            Customer customer = this.db.Customer.Find(key);
            if (customer == null)
            {
                return this.NotFound();
            }

            patch.Patch(customer);

            try
            {
                this.db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.CustomerExists(key))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.Updated(customer);
        }

        /// <summary>
        /// DELETE: ODataCustomers(5)
        /// </summary>
        /// <param name="key">customer key</param>
        /// <returns>HTTP response</returns>
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Customer customer = this.db.Customer.Find(key);
            if (customer == null)
            {
                return this.NotFound();
            }

            this.db.Customer.Remove(customer);
            this.db.SaveChanges();

            return this.StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// GET: ODataCustomers(5)/Addresses
        /// </summary>
        /// <param name="key">Customer key</param>
        /// <returns>Requested address</returns>
        [EnableQuery]
        public IQueryable<Address> GetAddresses([FromODataUri] int key)
        {
            return this.db.Customer.Where(m => m.Id == key).SelectMany(m => m.Addresses);
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
        /// Check if customer exist
        /// </summary>
        /// <param name="key">Customer key</param>
        /// <returns>True if exist</returns>
        private bool CustomerExists(int key)
        {
            return this.db.Customer.Count(e => e.Id == key) > 0;
        }
    }
}
