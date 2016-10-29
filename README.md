# UniversalApi
This is the Universal API. Whenever you need to write a new API this framework gives you all you need.
It works like GraphQL and OData but with a well known and rock solid syntax.

It supports all the HTTP verbs and it responds in Json.

Examples
---


Consider a Customer API. You can CRUD your customer at no cost. Just setup the database and issue the following commands:

**Get a customer list**

```curl http://youapiserver.com/api?q=SELECT name, surname FROM Customers```

**Get a single customer**

```curl http://youapiserver.com/api?q=SELECT name, surname FROM Customers WHERE id=1```

**Create a new Customer**

```curl -X POST --data "q=INSERT INTO Customers(name, surname) VALUES('carla', 'bianchi')" http://youapiserver.com/api```

**Update a customer** 

```curl -X PUT --data "q=UPDATE Customers SET name='Luca' WHERE id=1" http://youapiserver.com/api```

**Delete a customer** 

```curl -X DELETE --data "q=DELETE FROM Customers WHERE id=1" http://youapiserver.com/api```


NOTE
---
By now only SQL Server is supported.

*Developed with :trollface:*

