# The Wine Cellar 

## Version: 1.0

 Software Requirements:
	- Visual Studio 2019
	- NET Framework Version v.4.7.2
	- Sequel Server Management Studio
	- .Net 5.0

Hardware Requirements: 
-	Intel Core i3 (sixth generation or newer) or equivalent
-	4GB Ram
-	250GB Storage
-	Microsoft Windows 10 32-bit(x86) or 64-bit(x64)
-	15” LCD Monitor


## Description 
The Wine Cellar is an MVC (Model-View-Controller) web application developed using .NET Core. It serves as an online data management system for a wine farming company, facilitating the management of multiple farmers and their products. The platform provides employees with the means to add farmers to the database, view farmer and product listings, and manage the data. Additionally, registered farmers can log in to the application and add new wine products specific to their farm, enhancing collaboration and data input efficiency over the previous filing system.

## Installation Instructions – .NET 5.0 Framework 
1.	Launch the Visual Studio installer
2.	Select modify on the Visual Studio 2019 edition
3.	Select the individual components tab in the top right-hand corner
4.	Select .Net 5.0 runtime
5.	Install

## Running The Application 
1.	Unzip zipped folder named: SeanFowles_ST10084379_PROG7311_Part_2
2.	Double click folder named: TheWineCellarMVC
3.	Open: TheWineCellarMVC folder
4.	Open Bin folder
5.	Open Debug folder
6.	Open Net5.0 folder
7.	Double click TheWineCellarMVC application

## Instructions Opening in Visual Studio 2019 

1.	Unzip folder named: SeanFowles_ST10084379_PROG7311_Part_2
2.	Double click TheWineCellarMVC.sln to open with Visual Studio 2019
3.	Update-database in the Package Manager Console
4.	Press F5 on the keyboard to run the program

## Nuget Packages & Other Requirements 

- Microsoft.AspNetCore.Identity.EntityFrameworkCore (5.0.17)
- Microsoft.AspNetCore.Identity.UI (5.0.17)
- Microsoft.EntityFrameworkCore (5.0.17)
- Microsoft.EntityFrameworkCore.SqlServer (5.0.17)
- Microsoft.EntityFrameworkCore.Tools (5.0.17)
- Microsoft.Extensions.Identity.Core (5.0.17)
- Microsoft.VisualStudio.Web.CodeGeneration.Design (5.0.2)

## Database
Connection: Server=(localdb)\\mssqllocaldb;
Name: TheWineCellarMVC

## Running the Program

•	Update-database needs to be done before using the application
•	Open Visual Studio 2019
•	Tools -> Nuget Packet Manager
•	Package Manager Console
•	Update-database

## Logging in as Administrator
The Administrator access is seeded to the database, this role allows the user to create and assign roles to Employee and Farmer accounts, as well as access and use any of the other pages on the web app.
The Administrator role has already been created, the admin@twc.com username has been assigned to this role.
Log into the Administrator account as the initial account using the below details:
Email: admin@twc.com
Password: Admin#123

Once the Administrator has logged in, follow these steps to add the Employee and Farmer roles:
1.	Select Add Roles tab
2.	Select the Create a Role button
3.	Create two more roles – “Farmer” & “Employee” (this is case sensitive and must be spelt exactly as written)
4.	Log out
5.	Register two new accounts for a farmer and for an employee
6.	Log back in using Administrator account
7.	Select the Add Roles tab
8.	Select the correct role and click on the update button
9.	Add the farmers email to the “Farmer” role
10.	Add the employees’ email to the “Employee” role
Access will now be assigned for the Employee and Farmer roles according to their role. The Administrator is able to view all pages and content.


## Security
The process above is done to ensure that users are not able to grant themselves access to information that should be hidden or read-only. The Administrator account allows for control of the website over all accounts that are created. Once a user account is created, it can only be used once Administrator has granted its access. Farmers can only view products that they have entered, a farmer cannot view, edit, update or delete another farmers product. 

## FAQ
1.	When I log into the online application, will my data still be there?
Data is stored in a database that will ensure when you log in, your data previously entered will appear. Farmers can only view, edit and delete products that have been entered by that specific farmer. 

2.	Can I run the application without having Visual Studio 2019 installed on my computer?
It is possible to run the application in the console, please follow the ** running the application ** instructions at the top of this document.

3.	Why do I need a Superuser and Roles?
In order to control and restrict access to certain users, roles have been implemented. The Superuser is the only account that can create, edit and delete roles.

4.	Can I create and account and start using it immediately?
An account without a set role will have no functionality, the Superuser needs to approve the give the account the correct privileges by assigning it a role.

5.	How do I add a product?
Only Farmers can add products, the product will be added specifically under that farmers account. To add a product, log in as a Farmer and select the Add New Product tab, enter the required information and click on the Create button

6.	How do I search for a product using the product category? 
On the View Products page, use the top search box to search for all products in a specific category. The name of the category needs to be typed in exactly right in order to find the products that category contains, this includes casing.

7.	How do I search for a product using a Farmers Email?
On the View Products page, use the bottom search box to search for all products belonging to a specific farmer. Using the farmers email address that their account was created with. You can see which products below to which farmers by looking at the details tab of the product, here you will find the farmers email address.

8.	What if I have forgotten my password?
There is a forgot password option, however at this stage it is not linked to any email system. You will need to create a new account.

9.	My registration won’t work?
Ensure you have done the update-database command in the Nuget Package Manager Console. One the update-database has been done; the registration will work.

## Troubleshooting
Update Database
•	In order to connect and retrieve data from the database, the user needs to update-database in the package manager console. 
Ensure the correct connection string is used
•	Appsettings.json holds the connection string, it should be as follows:
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TheWineCellarMVC;Trusted_Connection=True;MultipleActiveResultSets=true"

# Implemented Design Patterns

## Factory Method 
The factory method design pattern is a creational pattern that is used when working with
object creation. The factory pattern loosens the coupling of the
code which in turn results in an application where the components do not heavily rely on
each other. Loosely coupled code produces applications that are easier to maintain, more
cost effective and more agile. In the Factory method, a products
construction code is separated from the code that actually uses the product.
The Factory design pattern allows for objects to be created without revealing the logic
behind them. An interface is brought in to create objects, however, the subclasses decide
which class to instantiate. 

## Prototype Method
Protype design pattern is a creational pattern that is used in the creation of objects, it allows
you to make an exact copy of a previously created object without being dependent on that
class. A prototype interface is implemented which is responsible
for creating a copy of an existing object. By using the Prototype pattern to copy objects, it is
possible to save resources and keep the applications performance high.

** Plugins **
•	ML.NET Model Builder 2019
•	Live Share
•	Web Live Preview (Preview)
•	Azure Data Lake and Stream Analytics Tools
•	Visual Studio IntelliCode
•	Cloud Explorer for VS 2019 Preview
•	Microsoft Library Manager
•	NetGetRecommender
•	Visual Studio Rich Navigation

## Developer Details
Name: Sean Fowles
Email: st10084379@vcconnect.edu.za
Phone Number: 0813033378

Please send any bugs encountered to the email address above or feel free to contact me on my cell number.
GitHub Repository Link: 


## Code Attribution
Bootswatch, 2023. Free Themes for Bootstrap. [Online] 
Available at: https://bootswatch.com/
[Accessed 20 May 2023].
CodeAffection, 2022. Asp.Net Core MVC CRUD Operations with EF Core. s.l.:CodAffection.
Dahmoun, H., 2020. How to Seed Users and Roles with Code First Migration using Identity ASP.NET Core. [Online] 
Available at: https://stackoverflow.com/questions/34343599/how-to-seed-users-and-roles-with-code-first-migration-using-identity-asp-net-cor
[Accessed 29 May 2023].
Joshi, N., 2021. Working With Searching Panel Application in MVC 5. [Online] 
Available at: https://www.c-sharpcorner.com/UploadFile/4b0136/working-with-searching-panel-application-in-mvc-5/
[Accessed 24 May 2023].
Yogi Hosting, 2022. How to work with Roles in ASP.NET Core Identity. [Online] 
Available at: https://www.yogihosting.com/aspnet-core-identity-roles/
[Accessed 16 May 2023].

