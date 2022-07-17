Part of the fun of software projects is getting them to run on machines with different environments and priveledges!

Here, I have some issues I ran into when trying to get the project to run on various other machines.

<hr />

<h4><b>General Issue: Startup Project</b></h4>
Make sure that both WebAPI AND WebForms are set as startup projects.
Right click the solution and click "Properties".
Select the radio button to select multiple startup projects.
Set both NorthernBrightHealth.WebAPI and NorthernBrightHealth.WebForms projects as the startup projects.

<hr />

<h4><b>Issue 1: "bin\roslyn\csc.exe" issues when the project is ran</b></h4>
Go to Tools > NuGet Package Manager > Package Manager Console
Paste the following:
```
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
```
<hr />

<h4><b>Issue 2:  Unable to connect to the remote server ---> System.Net.Sockets.SocketException: No connection could be made because the target machine actively refused it.</b></h4>
The project was likely cloned and is causing some sort of external source issues.
Try downloading the project instead of cloning it.

<hr />

<h4><b>Issue 3: .mdf file is not found or cannot be used as a databse.</b></h4>

The connection strings are not correct on the App.config/Web.config files.
In both NorthernBrightHealth.EF App.config and NorthernBrightHealth.WebAPI Web.config files, make sure the following is present:

```
<connectionStrings>
	<add name="NorthernBrightHealthDbContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthernBrightHealthDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" providerName="System.Data.SqlClient" />
</connectionStrings>
```

<hr />

<h4>Feel free to contact me with any issues</h4>
