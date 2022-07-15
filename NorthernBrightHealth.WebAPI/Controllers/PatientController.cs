using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthernBrightHealth.EF.Contexts;
using NorthernBrightHealth.Shared.Models;


namespace NorthernBrightHealth.WebAPI.Controllers
{
    public class PatientController : ApiController
    {
        // GET api/values
        public IEnumerable<Patient> Get()
        {
            // Return a list of all Patients
            try
            {
                using (var db = new NorthernBrightHealthDbContext())
                {
                    return db.Patients.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        // GET api/values/5
        public Patient Get(int id)
        {
            try
            {
                using (var db = new NorthernBrightHealthDbContext())
                {
                    return db.Patients.Where(i => i.PatientID == id).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        // POST api/values
        public void Post([FromBody] Patient patient)
        {
            // Posts the patient into the db context
            using (var db = new NorthernBrightHealthDbContext())
            {
                db.Patients.Add(patient);
                db.SaveChanges();
            }
        }

        // PUT api/values/5
        public bool Put(int id, [FromBody] Patient patient)
        {
            try
            {
                using (var db = new NorthernBrightHealthDbContext())
                {
                    var entity = db.Patients.Find(patient.PatientID);
                    if (entity == null)
                    {
                        return false;
                    }

                    db.Entry(entity).CurrentValues.SetValues(patient);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            using (var db = new NorthernBrightHealthDbContext())
            {
                var patient = db.Patients.FirstOrDefault(i => i.PatientID == id);
                db.Patients.Remove(patient);
                db.SaveChanges();
            }
        }
    }
}
