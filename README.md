# Kendo UI and Remote Data Sources
Recently, I was given a project to re-write. Before, it was based on the old ASP.NET Forms technology and relied on Telerik Rad Ajax controls on the client and your standard code-behind on the server. With this new version, I am going a different way with it. The new edition will utilize a client comprised of <a href="http://www.telerik.com/kendo-ui"> Telerik Kendo UI for jQuery</a> components and a backend created with <a href="https://msdn.microsoft.com/en-us/library/dn448365(v=vs.118).aspx">ASP.NET Web API 2</a>. This web api will then be deployed <a href="https://azure.microsoft.com">Microsoft Azure</a> App Fabric as a App Service. The client script will then be used in a custom partial view inside an <a href="https://umbraco.com">Umbraco CMS</a> we use.

Telerik Kendo UI components have been around for a while now and if you are licensed to use them, they can be a real time saver. They are pro tools so the results you get from them can be outstanding. The demos they provide are very useful but they are a bit lacking in certain areas.

A good example is implementing CRUD operations on remote data sources. As it would be nearly impossible for Telerik to provide examples of many different types of services, finding examples specific to your needs can be difficult, to say the least. It is the aim of this repository to give you enough information for the given scenario to get you started.

# C-Sharp Corner to the rescue
One of the only truly useful resources I could find was <a href=" http://www.c-sharpcorner.com/uploadfile/fc9f65/crud-operation-in-kendo-grid-using-web-api/">this example</a>. Hat's off to the good folks at <a href="http://www.c-sharpcorner.com">C-Sharp Corner</a>, an awesome resource! 

# So, how is this any different?
Here you will find a very comprehensive example that will show you how ALL of it works, from soup to nuts.

In this repository you will:

1. Create a Web API 2 project in Visual Studio using Entity Framework
2. Deploy the Web API 2 project to Microsoft Azure
3. Test the Web API 2 using Postman
4. Create an index.html page containing a Kendo UI Grid
5. Implement the CRUD operations against your remote data source 
6. Correct some issues with the Web API 2 
7. Review what we've learned and how it can be applied elsewhere.

What will make this different is that it puts all of the pieces together which should get you up and running rapidly. If you are an enterprise developer that has never worked "client side", this should help you understand how it all fits together.
