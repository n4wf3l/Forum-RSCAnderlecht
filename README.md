# RSCAnderlecht Forum

This project utilizes ASP .NET Core MVC 6 and is updated on the feature-post branch. It focuses on creating a forum for RSC Anderlecht fans, with backend work primarily done in C#. Key features include Identity management, scaffolding, filter search, database connectivity, user authentication, role-based authorization, email confirmation, and multilingual support (EN-NL-FR).  This project caters to supporters in three languages. Each registered user designates a favorite club and gains access to a range of features, including the ability to view and engage with content posted by fellow fans, complete with like functionality and beyond.

### Launch Instructions:

To launch the website on your device, follow these steps:

1. Delete the "Migrations" folder.
2. Open your Package Manager Console.
3. Type "Add-Migration test -Context aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context".
4. Type "Update-database".
5. Log in with the two accounts already created in the ApplicationDbContext:
   - Normal User: user1@user.com / Password: User1-123
   - Admin: admin1@test.com / Password: Admin1-123
6. Create an account for yourself. Upon registration, you will automatically become a User and receive a confirmation email to activate your account.
7. Create an Admin account from the User Management page within the main Admin account.

Enjoy the RSC Anderlecht Forum!
