Microservices Overview
In this project, I developed two microservices:

Patient Microservice

Provider Microservice

Each microservice exposes two GET APIs to retrieve relevant data.

API Gateway with YARP
To manage and route requests between clients and these microservices, I implemented an API Gateway using YARP (Yet Another Reverse Proxy).

YARP is a highly customizable and performant reverse proxy library developed by Microsoft. It is built on ASP.NET Core and designed to handle dynamic routing, load balancing, and request transformation with ease.

In this project, the API Gateway uses YARP to:

Route incoming requests to the appropriate microservice

Simplify client interaction by exposing a unified entry point

Enhance scalability and separation of concerns in the microservices architecture
