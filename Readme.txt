*******************************************************************************
C# 2010 Black Book
CD–ROM CONTENTS
*******************************************************************************

The companion CD-ROM contains complete source code for Sports Project, the book's applications, organized by chapters, DirectX 9.0 Re-distributable to enhance the use of this book.

Note: Visual Studio 2010 Ultimate Edition software (not included on this CD-ROM) is required to complete the projects in this book.

Installing the Examples 

This CD holds the code for the examples used in the book chapter and Bonus chapter (given in CD). You'll find the code in chapter-by-chapter folders under the "Source Codes\Bonus Chapter's Code" and "Source Codes\Book Chapter's Code" folder (for example, the “Source Codes\Book Chapter's Code\Chapter 4\” folder holds examples from Chapter 4), and each example program has its own folder in those chapter folders. 

For instance, the “MyObject” example in Chapter 4 is in the “Source Codes\Book Chapter's Code\Chapter 4\MyObject” folder, and so on. 

Ideally, the examples are meant to be placed in a folder named “C:\C#” that you’ve created on your “C:” drive. To run the examples, create the folder “C:\C#\” in your C drive. Next, copy the folders for the chapters you want to work with to “C:\C#”. For example, to install the examples from Chapter 4, use Windows Explorer to drag the folder “Chapter 4” from the CD to “C:\C#” so that it becomes “C:\C#\Chapter 4”. After you've done this, you can find the “MyObject” example from Chapter 4 in the folder named “C:\C#\Chapter 4\MyObject”, and so on. 

That's the best way to run the examples for a particular chapter--create the folder “C:\C#”, then drag that chapter's complete folder from the CD to “C:\C#”. (You can, of course, drag individual files one at a time.) 

It's important to realize that Microsoft Windows marks all files from a CD as read-only by default, which means they'll be marked as read-only when you copy them onto your hard drive (there's no way to avoid this when you're copying files from a CD in Windows). You can remove the read-only attribute by selecting files in the Windows Explorer (either singly or in groups) right-clicking them, selecting the Properties item, and deselecting the read-only attribute in the Properties dialog box that opens. 

After you've placed an example project from the CD onto your hard drive and removed the read-only attributes, just open that project in C# as you would any other project. To run most projects, just select the “Debug|Start” menu item. Note that there are a few special considerations for particular types of projects--Web projects and data projects. We'll take a look at those considerations here. 


Installing Web Projects

Installing a Web project is a little trickier, because these projects must be registered with your installation of IIS. You'll find the source code (not the complete project files) for the Web projects developed in the book on the CD. Please follow the steps given here to work with Web projects. 

Copy the selected chapter code in “C:\C#” folder. For example, if you like to work with Chapter 16, copy “Chapter 16” folder to “C:\C#”. 

Now open your IIS to change the Home directory property of Default web site. 

Change the Home directory location to the folder you have just copied in first step. For example, if you are working with Chapter 16 then your Home directory should point to “C:\C#\Chapter 16” and “C:\C#\Chapter 17” for Chapter 17 and so on. 

Now open your browser and type http://localhost. You will see that everything is working fine and your IIS is also running. 

After completing these steps, you are now ready to work with the Web applications. Open Visual Studio 2010 and open the desired project file from its corresponding location. For example, if you want to open “LoginandLoginViewControls” from Chapter 16, then you will find its project file in “C:\C#\Chapter 16\LoginandLoginViewControls\” folder. 

After opening the file, build the solution again. Visual Studio may ask you to overwrite the solution file. Overwrite the solution file and you are ready to run the project. 

Installing Database Projects

In addition, some example projects work with databases. We strongly recommend that you re-create these examples from scratch, following the directions in the book. 

However, if you try running the examples, as they are on the CD, at a minimum you will probably need a connection to a data provider. Not all examples will need such a connection, because some will create their own data sources. However, if you see a connection object when you open an example project (this object will be named “SqlConnection1” or “OleDbConnection1”), you'll need to update that object to point to one of your own working data connections. 

In the book, we've used connections to the Microsoft SQL Server's Northwind example database, almost exclusively to make this easier. The recommended procedure here is used first to create a connection to the Northwind database in C# (see Chapter 24 for the details). Then find the Connection object in the example project (“SqlConnection1” or “OleDbConnection1”), click its “ConnectionString” property in the Properties window, and select your connection to the Northwind database from the drop-down list that appears. 

Troubleshooting

C# projects are not specifically designed to be transferred between computers; if you can't get a project working as is, please accept our apologies and re-create the project by following the step-by-step instructions given in the book.

Some of the Web applications use ASP.NET specific tags (for instance the “authentication” tag in “web.config” file) that may raise problems during execution and you would see the errors in your browser. 

Let's read more about errors.

Configuration Error

Configuration error occurs during the processing of a configuration file required to service the current request. Please review the following specific error details and modify your configuration file accordingly. 

Parser Error Message: Refers to an error message that is displayed when a section is registered as “allowDefinition='MachineToApplication'” beyond application level. This error message is displayed when a virtual directory that is not configured as an application in IIS.

Source Error: Refers to an error that is caused by misplacing of an application. An example of the source error is given as follows:

Line 37:    by Microsoft that offers a single logon and core profile services for member sites.
Line 38:     -->
Line 39:     <authentication mode="Windows" /> 
Line 40: 
Line 41: 

To rectify the source error, open the properties of your application in IIS and click the Create button, which would create an application for your project. 

All the examples of the book have been formally verified, on at least two different machines and by at least two different people, to work properly. We did our best to handle changes in Visual C# as they occur, but unfortunately, there's no way to predict them in advance.

Finally, and most importantly...Happy Programming!


Limits of Liability & Disclaimer of Warranty

Although the author and publisher have taken every precaution when preparing this disk, they make no expressed or implied warranty of any kind and assume no responsibility for errors or omissions.