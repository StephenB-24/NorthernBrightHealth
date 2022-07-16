using Newtonsoft.Json;
using NorthernBrightHealth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthernBrightHealth.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            initializeHeightElement();
        }

        // Creates the height drop down list.
        private void initializeHeightElement()
        {
            for (int feet = 1; feet < 9; feet++)
            {
                for (int inches = 0; inches < 12; inches++)
                {
                    string feetStr = feet.ToString() + "\'";
                    string inchesStr = inches.ToString() + "\"";

                    // Calculate inches for the value (saves time later)
                    int totalInches = (feet * 12) + inches;

                    ListItem newHeightOption = new ListItem(text: feetStr + " " + inchesStr,
                                                            value: totalInches.ToString());
                    newHeightOption.Attributes["OptionGroup"] = feetStr;

                    inputHeight.Items.Add(newHeightOption);
                }
            }
        }
        
        // Called by the submit button, submits the patient
        protected void SubmitPatient(object sender, EventArgs e)
        {
            string responseMessage = "";

            try
            {
                Patient newPatient = new Patient()
                {
                    FirstName = inputFirstName.Text,
                    LastName = inputLastName.Text,
                    DateOfBirth = DateTime.Parse(inputDateOfBirth.Text),
                    WeightInPounds = float.Parse(inputWeightInPounds.Text),
                    HeightInInches = int.Parse(inputHeight.Text),

                    DateAdded = DateTime.Now,
                    DateLastUpdated = DateTime.Now
                };

                HttpClient httpClient = Managers.HttpClientManager.GetHttpClient();
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(newPatient), Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync("api/Patient", httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    litResponse.Text = "<p> Hooray!" + inputFirstName.Text + " " + inputLastName.Text + " is now cured of all sickness, and made immortal!</p>";
                    inputFirstName.Text = "";
                    inputLastName.Text = "";
                    inputDateOfBirth.Text = "";
                    inputWeightInPounds.Text = "";
                }
            }
            catch (Exception responseException)
            {
                responseMessage = responseException.ToString();
                litResponse.Text = "<p>" + responseMessage + "</p>";
            }
        }
    }
}