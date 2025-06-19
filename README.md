# Code interview

Welcome to [wangkanai](https://github.com/wangkanai) code interview, the interview will be 1 hour with time extension approval (points deductible). 
Please read the instruction clearly and design your solution accordingly. 
Your will evaluate base on your coding principles and solution folder structuring. 
I will watching your screen share throughout the entire code interview. 
If you counter a mind blocking issue, you may search the internet for help (this is part of problem solving).
Yes, you may use any AI assistant (ChatGPT, Copilot, & etc) to help you during the code interview.
During the code interview, you will be ask to explain your code and design decision.
If you have any question, please ask me at anytime during the session.

You will have to fork this [code interview](https://github.com/wangkanai/interview/fork) repo and clone it to your local development machine. 
Prepare your development environment and create your pull request to the original repo. 
You may commit as much as you like, I have setup CI for you to evaluate you code with sonarqube. 
I have also included `.editorconfig` for code format consistency, so you can focus on the logic of your development.

The [vertical slice architecture](Vertical Slice Architecture) with features as the folder structure.

Don't be afraid in why the interview is so complicated.
This will be your actual development environment when you have successfully joined our team.

I wish the best of luck :)

Best regards,

Sarin Na Wangkanai

## Vertical slice architecture

The vertical slice architecture is a way to organize your codebase by features. 
Each feature will have its own folder structure with domain, application, infrastructure, endpoint, and testing. 
This will help you to focus on the feature you are working on and make it easier to find the code you need.

## Solution background

During our code interview, you will be building a solution for managing projects and tasks. 
Task can have hierarchy with parant task and children tasks. 
Task must have start and target datetime when initial creation. 
Also don't forget title and description of the task with audit trace. 
Now you need to have the actual completed datetime to do comparison of the planned vs actual report. 
Task will have to make progress updates with the percentage completed upon the task. 
Now come the fun part, we need manage predecessor and successor linkage, 
to make it easy in such limited time the task timespan shall not overlap each other for your validation logic before saving to the backend microservice.

## Solution requirements

The development must be [.NET 8.0](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8/overview) using [C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12) projects. 
We will also be using [.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/app-host-overview) to be our orchestration. 
The front end will be developed with [Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-8.0) using both hosting model of [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0#blazor-server) and [Blazor WebAssembly](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0#blazor-webassembly). 
We will be using interactive render mode, so both hosting mode are required to be implemented.
For authentication and authorization we will be using [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0)

The microservices will be develop in [ASP.NET Core Web Api](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio) with feature base folder. 
The persistence database will be [PostgreSql](https://www.postgresql.org/), 
in which the configuration provider is fully utilize PostgreSQL features.

You will also need to have unit tests, integration tests, and functional tests. 
We will being using the [XUnit](https://xunit.net/) testing framework.

## Solution setup

I have create the base working solution for you already with basic folder structure.

1. [Aspire](Aspire)
2. [Microservices](Microservices)
3. [Portal](Portal)

Our vertical slice architecture will be setup in the following project structure;

1. Domain
2. Application
3. Infrastructure
4. Endpoint(Server)
5. Testing

## Bonus points

1. [Centrally package management](https://learn.microsoft.com/en-us/nuget/consume-packages/central-package-management)
2. [Seq Centralized structured Logs](https://datalust.co/seq)
      
## Interview scoring method

1. Read the code interview instruction clear before the session
2. On time for the code interview
3. Able to start the code interview into development environment asap
4. Good understand of the solution folder structure and follow the setup mandate
5. Good practise in SOLID - Single-responsibility principle:
6. Good practise in SOLID - Open–closed principle
7. Good practise in SOLID - Liskov substitution principle
8. Good practise in SOLID - Interface segregation principle
9. Good practise in SOLID - Dependency inversion principle
10. Good practise in dependancy injection and service lifecycle
11. Good practise in Domain-Driven-Design
12. Good practise in Test-Driven-Design
13. Good practise in Event-Driven-Design
14. Good understand of Vertical Slice Architecture
15. Good understand of ASP.NET Core Web Api
16. Good understand of ASP.NET Core Hosted Worker Service
17. Good understand of ASP.NET Identity and how to extend it features
18. Good understand of ASP.NET Blazor Server
19. Good understand of ASP.NET Blazor WebAssembly
20. Good understand of ASP.NET Blazor render mode
21. Good understand of Entity Framework Core
22. Good understand of Postgres and Npg provider
23. Good understand of .NET Aspire orchestration
24. Good understand of Xunit testing framework
25. Good understand of Microservice
26. Good practise of clean code
27. [Bonus] Centrally package management
28. [Bonus] Seq Centralized structured Logs
29. [Bonus] Stack trace debugging for root cause analyze
30. [Bonus] Sql performance obtimization
