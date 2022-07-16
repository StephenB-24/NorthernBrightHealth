<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NorthernBrightHealth.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="computer-inner-screen">
        <h1>Welcome to the Future of Healthcare.</h1>
        <h4>Here at Northern Bright Health, we offer service that cannot be beat (literally)! </h4>
        <hr style="background-color: white;" />

        <p class="descriptive-text">Please enter the patients name below:</p>

        <div class="container form-outline  row-no-gutters">
            <%-- First Name --%>
            <div class="form-group col-xs-12 col-sm-6 col-lg-4" style="display: inline">
                <asp:Label for="inputFirstName"
                    Text="First Name"
                    runat="server" />
                <asp:TextBox ID="inputFirstName"
                    type="text"
                    runat="server" />
            </div>

            <%-- Last Name --%>
            <div class="form-group col-xs-12 col-sm-6 col-lg-4" style="display: inline">
                <asp:Label for="inputLastName"
                    Text="Last Name"
                    runat="server" />
                <asp:TextBox ID="inputLastName"
                    runat="server" />
            </div>

            <%-- Date of Birth --%>
            <div class="form-group col-xs-12 col-sm-6 col-lg-4" style="display: inline">
                <asp:Label for="inputDateOfBirth"
                    Text="Date of Birth"
                    runat="server" />
                <asp:TextBox ID="inputDateOfBirth"
                    TextMode="Date"
                    min="01-01-1850"
                    value="2000-01-01"
                    runat="server" />
            </div>

            <%-- Weight --%>
            <div class="form-group col-xs-12 col-sm-6 col-lg-4" style="display: inline">
                <asp:Label for="inputWeightInPounds"
                    Text="Weight (lbs)"
                    runat="server" />
                <asp:TextBox ID="inputWeightInPounds"
                    TextMode="Number"
                    pattern="[0-9]+"
                    runat="server" />
            </div>

            <%-- Height --%>
            <div class="form-group col-xs-12 col-sm-6 col-lg-4" style="display: inline">
                <asp:Label for="inputHeight"
                    Text="Height (ft/in)"
                    runat="server" />
                <asp:DropDownList ID="inputHeight" runat="server" />
            </div>
        </div>

        <asp:Literal ID="litResponse"
            runat="server" />

        <%-- Submit Button --%>
        <div class="submission-button">
            <asp:Button CssClass="submission-button" Text="Submit Patient"
                OnClick="SubmitPatient"
                runat="server" />
        </div>
    </div>
</asp:Content>
