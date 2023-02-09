# RSCAnderlechtF
ASP .NET Core MVC 6 - Updated project on branch feature-post - RSC Anderlecht Forum (Backend work in C#) : Identity, Scaffolding, Filter-search, Connection with Db, Userclass-IdentityUser, Admin/User Role with 2 Seeding-accounts &amp; Authorization, Email-Confirmation, IdentityAppDbContext, Admin can make user Admin, Middleware (Cookies), EN-NL-FR

In order to launch the website on your device, follow these steps: 
- Delete the "Migrations" folder
- Open your Manage Console package
- Type "Add-Migration test -Context aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context"
- Type "Update-database"
- Log in on the two accounts already created in the ApplicationDbContext.
* The first one is a normal User: user1@user.com / Password: User1-123
* The second one is an Admin : admin1@test.com / Password : Admin1-123
* Create an account yourself, you will automatically become a User. You will automatically receive a confirmation email to activate your account!
* Create yourself an Admin from the User Management page in the main Admin account!
