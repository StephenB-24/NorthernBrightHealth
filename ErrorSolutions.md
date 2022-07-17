Part of the fun of software projects is getting them to run on machines with different environments and priveledges!
Here, I have some issues I ran into when trying to get the project to run on various other machines.

General Issue: Startup Project
Make sure that both WebAPI AND WebForms are set up at startup projects.
Right click the solution and click "Properties".
Select the radio button to select multiple startup projects.
Set both NorthernBrightHealth.WebAPI and NorthernBrightHealth.WebForms projects as the startup projects.

Issue 1: "bin\roslyn\csc.exe" issues when the project is ran
Go to Tools > NuGet Package Manager > Package Manager Console
Paste the following:
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r

Issue 2:  Unable to connect to the remote server ---> System.Net.Sockets.SocketException: No connection could be made because the target machine actively refused it.
The project was likely cloned and is causing some sort of external source issues.
Try downloading the project instead of cloning it.

Issue 3:
.mdf file is not found or cannot be used as a databse.

The connection strings are not correct on the Web.config files.
In both NorthernBrightHealth.EF and NorthernBrightHealth.WebAPI Web.config files, make sure the following is present:
<connectionStrings>
	<add name="NorthernBrightHealthDbContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthernBrightHealthDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" providerName="System.Data.SqlClient" />
</connectionStrings>