using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthernBrightHealth.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    // Get the values from the form
        //    string firstName = txtFirstName.Text;
        //    string lastName = txtLastName.Text;
        //    DateTime dateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
        //    int heightInInches = int.Parse(txtHeightInInches.Text);
        //    int weightInPounds = int.Parse(txtWeightInPounds.Text);
        //    bool immortal = chkImmortal.Checked;

        //    // Create a new patient
        //    Patient patient = new Patient();
        //    patient.FirstName = firstName;
        //    patient.LastName = lastName;
        //    patient.DateOfBirth = dateOfBirth;
        //    patient.HeightInInches = heightInInches;
        //    patient.WeightInPounds = weightInPounds;
        //    patient.Immortal = immortal;

        //    // Add the patient to the db context
        //    using (var db = new NorthernBrightHealthDbContext())
        //    {
        //        db.Patients.Add(patient);
        //        db.SaveChanges();
        //    }
        //}
    }
}