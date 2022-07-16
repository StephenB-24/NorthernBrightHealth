<h1>Northern Bright Health</h1>
<h3>Description</h3>
<hr />

<em>The year is 3000. Many advances have been made in healthcare over the past millenium. At this time, all one has to do is take a trip to the Triangulum Galaxy within our local group of the Virgo Supercluster. Here, NorthernBrightHealth can make any patient immortal with a mere snap of the fingers.</em>

![image](https://user-images.githubusercontent.com/76532502/179167550-ec62fa9c-8fff-4478-982e-92d86ffb6339.png)

<em>As an employee of NorthernBrightHealth, you have full access to this cutting edge technology. Add patients as you wish, saving them of all sicknesses... forever. That is, until production servers are accidently wiped by an intern 😅.</em>

Note: This solution was made with the ASP.NET Web Forms project as the main intention of the project.
A seperation-of-concerns approach is used, so more projects are present.

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
Logging
Validation of form
Improvements to CSS
