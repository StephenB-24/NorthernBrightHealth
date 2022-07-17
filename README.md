<h1>Northern Bright Health</h1>
<h3>Description</h3>
<hr />

<em>The year is 3000. Many advances have been made in healthcare over the past millennium. At this time, all one has to do is take a trip to the Triangulum Galaxy within our local group of the Virgo Supercluster. Here, NorthernBrightHealth can make any patient immortal with a mere snap of the fingers.</em>

![image](https://user-images.githubusercontent.com/76532502/179167550-ec62fa9c-8fff-4478-982e-92d86ffb6339.png)

<em>As an employee of NorthernBrightHealth, you have full access to this cutting-edge technology. Add patients as you wish, saving them of all sicknesses... forever. That is, until production servers are accidentally wiped by an intern 😅.</em>

Note: This solution was made with the ASP.NET Web Forms project as the main intention of the project.
A separation-of-concerns approach is used, so more projects are present.

<h3>Instructions to Run</h3>
<hr />

<p>Load the project up in Visual Studio. As a note, I used Visual Studio 2022 for this project.</p>

<b>1) The most important aspect of running this project is to make sure that both the WebAPI and WebForms apps are set as startups together.</b>

To do so, right-click on the <b>solution</b> and then click properties, and select the radio button for multiple startup projects. Select both the WebAPI and the WebForms project as startups.

<b>Next, you will likely need to reinstall DotNetCompilerPlatform</b>

To do so, go to "Tools > NuGet Package Manager > Package Manager Console" and then enter the following:
```
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
```

Upon pasting the prior, it will immediately start reinstalling.
It should look like the following after completing:

![image](https://user-images.githubusercontent.com/76532502/179422153-5a23ff4b-7527-485c-85a1-8c7b1903b2a0.png)

<b>You are now ready to run the project! Note that the first patient inserted will take longer because the database will be created and migrated by the WebAPI when it receives the first request.</b>

If you have further issues, check the error solutions readme. I attempted to run this project on various other machines to create a generalized way of running the project that works.

<h3>Screenshots</h3>
<hr />

<h5>Main Menu - Add Patients</h5>

![image](https://user-images.githubusercontent.com/76532502/179421863-248c115d-37c4-41ff-933b-95c3da01018c.png)

<h5>Main Menu - Patient Added</h5>

![image](https://user-images.githubusercontent.com/76532502/179421895-eeb9d6a3-9c06-46df-9d08-4a9a360fca6d.png)

<h5>View Patients - AJAX Table Results</h5>

![image](https://user-images.githubusercontent.com/76532502/179421925-95bb08de-afa2-4d0b-9e90-e76e0f0c97c6.png)

<h3>Solution Breakdown</h3>
<hr />
<ul>
  <li>NorthernBrightHealth.EF - A class library project that uses Entity Framework 6 with a code-first approach</li>
  <li>NorthernBrightHealth.WebAPI - A WebAPI project for use by the Web Forms project. The WebAPI is seperate from the Web Forms app intentionally to allow for future applications to have easy access to the API.</li>
  <li>NortherBrightHealth.WebForms - An ASP.NET WebForms project. The current user interface for this project.</li>
  <li>NorthernBrightHealth.Shared - A "shared" class library project containing items that are shared amongst the projects.</li>
</ul>

<h3>Diagram</h3>
<hr />

![image](https://user-images.githubusercontent.com/76532502/179172504-f07b65a3-2df7-4ec5-80af-7e34a8fcf219.png)

Note: Business logic could be abstracted from the WebAPI to further decompose the solution.
<h3>Backlog</h3>
<hr />

Make the computer feel as though it is in a spaceship or on some sort of exo-planet

Logging

Validation of form

Improvements to CSS

Add descriptions to the API calls within the WebAPI project
