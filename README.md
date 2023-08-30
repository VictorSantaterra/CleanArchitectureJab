# Clean Architecture Jab

A Simple layered Clean Architecture API sample using the compile time dependency injection package [Jab](https://github.com/pakrym/jab) 

---
Unfortunately, the package doesn't have support to work with ASP.NET Core Web API nowadays... however, I tried something simple and it worked well

Some pros and cons:

Pros
 - Compile time validation for your service dependencies
 - Compile time validation for services that don't exist on the provider
 - Faster API startup
 - Faster service providing
 
Cons
- Doesn't import internal implementations from external module services provider
- Doesn't have support for services injection by controllers or minimal endpoints
- You need to control scoped services by yourself 
- External packages made on top of Microsoft Dependency Injection are not supported
- Dependencies resolved on runtime are not supported

Although I have tried a little bit... I'm probably not going to use this package again until get support for ASP.NET Core Web API..
