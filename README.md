# Asp.Net Core Clean Architecture
Clean Architecture demo with Asp.Net core 7

## What is Clean Architecture?

Clean architecture has a domain layer, Application Layer, Infrastructure Layer, and Framework Layer. The domain and application layer are always the center of the design and are known as the core of the system. The core will be independent of the data access and infrastructure concerns.

![image](https://user-images.githubusercontent.com/46478151/215721668-b9bff7ee-d7e3-449b-819a-b96f99fef893.png)

 We can achieve this goal by using the Interfaces and abstraction within the core system, but implementing them outside of the core system.
 
 ## Layer In Clean Architecture
 
Clean architecture has a domain layer, Application Layer, Infrastructure Layer, and Presentation Layer. The domain and application layer are always the center of the design and are known as the core of the system.

### Domain Layer:

The domain layer in the clean architecture contains the enterprise logic, like the entities and their specifications. This layer lies in the center of the architecture where we have application entities, which are the application model classes or database model classes, using the code first approach in the application development using Asp.net core these entities are used to create the tables in the database.

### Application Layer

The application layer contains the business logic. All the business logic will be written in this layer. It is in this layer that services interfaces are kept, separate from their implementation, for loose coupling and separation of concerns.

### Infrastructure Layer

In the infrastructure layer, we have model objects we will maintain all the database migrations and database context Objects in this layer. In this layer, we have the repositories of all the domain model objects.

### Presentation Layer

In the case of the API Presentation layer that presents us the object data from the database using the HTTP request in the form of JSON Object. But in the case of front-end applications, we present the data using the UI by consuming the APIS.

## Advantages of Clean Architecture
-The immediate implementation you can implement this architecture with any programming language.
-The domain and application layer are always the center of the design and are known as the core of the system that why the core of the system is not dependent on external systems.
-This architecture allows you to change the external system without affecting the core of the system.
-In a highly testable environment, you can test your code quickly and easily.
-You can create a highly scalable and quality product.

## Clean Architecture vs N-Tier Architecture
Clean architecture is the evolution of the software application architecture which put the domain model in the center, but not the database as it was in an n-tier architecture. Also, the dependency rule is the main postulate of this architecture. Dividing the system into the layers makes it testable.

Both architecture styles apply layers to separate concerns, however they do that in a different way.

** The n-tier architecture is about communicating with the database through layers of business logic and representation. It is tightly coupled to the externals (3rd party frameworks/drivers) you want to use, for example to an HTTP Server, an ORM or an SQL driver...

** The clean architecture is about implementing use cases and build layers of adapters and externals (3rd party frameworks/drivers) around them. It is loosely coupled to the externals you want to use because of the layer of the adapters. Be aware that by the clean architecture the representation and the database layers would be both included by the externals. So the clean architecture is more about creating an application and separate it from the externals it uses to communicate with its environment. In this scenario it is much easier to test, develop and maintain the code of the application. You don't have to write integration tests or mock out the ORM to test the business logic. You don't have to concern about the externals by implementing the business logic, you can focus on the application itself. You don't have to modify the business logic to replace any external framework/driver, it's enough to write a new adapter to accomplish that.
