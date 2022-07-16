<%@ Page Title="View Patients" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPatients.aspx.cs" Inherits="NorthernBrightHealth.WebForms.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                type: "GET",
                url: "https://localhost:44356/api/Patient/",
                data: '{}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    console.log('here1');
                    console.log(response);
                    /*var obj = JSON.parse(response);*/

                    var rows = '';

                    for (var x in response) {
                        var obj = response[x];
                        var id = obj.PatientID;
                        var fn = obj.FirstName;
                        var ln = obj.LastName;
                        var dob = obj.DateOfBirth;
                        var weight = obj.WeightInPounds;
                        var height = obj.HeightInInches;
                        var immortal = obj.Immortal;
                        var added = obj.DateAdded;
                        var updated = obj.DateLastUpdated

                        rows += "<tr><td>" + id + "</td><td>" + fn + ' ' + "</td><td>" + ln + "</td><td>" + dob + "</td><td>" + weight + "</td><td>" + height + "</td><td>" + immortal + "</td><td>" + added + "</td><td>" + updated + "</td></tr>";
                    }
                    console.log(rows);
                    $('.tblPatients tbody').append(rows);
                    console.log('here');
                },
                error: function (response) {
                    var r = jQuery.parseJSON(response.responseText);
                    alert("Message: " + r.Message);
                }
            });
        });
    </script>

    <div class="outer-screen">
        <h1>Patients</h1>
        <h4>Below are the patients you have cured</h4>
        <hr />
        <div class="table-responsive">
            <table class="tblPatients table" border="1">
                <thead>
                    <tr>
                        <th>Patient ID</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Date of Birth</th>
                        <th>Weight (lbs)</th>
                        <th>Height (in)</th>
                        <th>Immortal</th>
                        <th>Date Added</th>
                        <th>Date Last Updated</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
