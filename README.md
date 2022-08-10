# NZMSA-2022-Phase-2


Backend:

Section One:

Different configuration file can link to different environment. For example, when using appsettings.development.json config file you can run your application under development environment. Of course, you need to set up the DB connection string or point to the specific IP address. When everything is ready on production, developer might be use appsettings.production.json as config file. Another good thing is, using different configuration file can help developer save time. They dont need to change the hard cord connetion sting, API address or IP address.


Section Two:

Middleware via DI (dependency injection) like (Swagger, plug in) helps developer to save time and write less duplicate code. It is easy to use and clearly show its structure. For example, student just need to go 'NuGet Package Manager' and search the right version, install into your project. Then your project can import the pack from everywhere.


Section Three:

Middleware libraries like Nunit, has comprehensive build in functions. Developer doesn't need to write the testing case from the ground up. For example, Assert.True, Assert.AreEqual, Assert.Positive etc. These classic models help me to test faster, I don't need to write a loop and paste parameter and debug the testing case code etc. On the one had, I can test my code faster. On the other hand, I don't to write duplicated methods or function. Furthermore, it helps me to write more accurate code. I can find my bug in time and fix it before I submit my assignment.