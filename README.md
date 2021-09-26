# web_app_hobbys
Web application to manage hobbies for persons

Users must be able to:
1. Add Persons
 - [ ] Under tab "New Person" (Person/Create)
3. Delete Persons
 - [ ] Under tab "View Persons". Every person has a "delete" option.
4. Add hobbies to a person
 - [ ] Under tab "View Persons". Every person has a "details" options. You can add hobbies to a person from there ("Add hobby")
 - [ ] If there are no options you can create hobbies under "New Hobby"
5. Remove hobby/hobbies from a person
 - [ ] Under tab "View Persons". Every person has a "details" options. You can delete hobbies there.
Extra requirements:
1. Paging, max 20 visible
 - [ ] Paging added to "View Persons"
2. Support for 10.000 persons
 - [ ] Depending on your machine
Non-Functional requirements:
1. Web based
 - [ ] ASP.NET
2. Data must be stored in a database
 - [ ] database is included. you probably need to publish it first and change the connectionStrings in web.config
<details>
connectionStrings:
add name="AssignmentDB" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AssignmentDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
</details>
3. Styling is preferred
 - [ ] basic styling included
4. Strong preference to have it working In Azure
 - [ ] ran out of time. 
5. A solution built in dotNet scores additional points
 - [ ] No problem
