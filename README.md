# Code interview

Welcome to [wangkanai](https://github.com/wangkanai) code interview, the interview will be 1 hour with time extension approval (points deductible). 
Please read the instruction clearly and design your solution accordingly. 
Your will evaluate base on your coding principles and solution folder structuring. 
I will watching your screen share throughout the entire code interview. 
If you counter a mind blocking issue, you may search the internet for help (this is part of problem solving).
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

## Solution background

During our code interview, you will be building a solution for managing projects and tasks. Task can have hierarchy with parant task and children tasks. Task must have start and target datetime when initial creation. Also don't forget title and description of the task with audit trace. Now you need to have the actual completed datetime to do comparsion of planned vs actual report. Task will have to make progress updates with percentage completed upon the task. Now come the fun part, we need manage predecessor and successor linkage, to make it easy in such limited time the task timespan shall not overlap each other for your validation logic before saving to the backend microserivce.

## Solution requirements

The development must be [.NET 8.0](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8/overview) using [C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12) projects. We will also be using [.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/app-host-overview) to be our orchestration. The front end will be developed with  [Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-8.0) using both hosting model of [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0#blazor-server) and [Blazor WebAssembly](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0#blazor-webassembly). For authentication and authorization we will be using [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0)

The microservices will be develop in [ASP.NET Core Web Api](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio) with feature base folder. The persistence database will be [PostgreSql](https://www.postgresql.org/)

You will also need to have unit tests, integration tests, and functional tests. We will being using the [XUnit](https://xunit.net/) testing framework.

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
      






