# MVC-101

My first MVC project. In this project, I only performed basic CRUD operations to understand the MVC logic. For example, I performed listing-deletion-update-add and fetch by id for a product table. The reason why I used Model-View-Controller structure in this project was to enable me to write faster and cleaner code thanks to MVC.

## Use to Libraries 

- .NET Framework (4.6.1)
- Entity Framework (6.0.0)

## Use to Model 
- ADO.NET Entity Data Model


## Project Setup

* First you need to install [Visual Studio](https://visualstudio.microsoft.com/en/).

* You need to select ASP.NET Web Application(.NET Framework) option and choose its version. *Ins.* I developed the project with version 4.6.1.

* After choosing your project name and version, a screen comes up where you can choose how to develop the application in the next step. Since we will use MVC, we choose the MVC option.

**That's it, your project is ready to code.**

## Project Details

1. By creating an Entity folder in the Models area, I included the Entity Framework library I installed in MySql and the table I prepared using ADO.NET Entity Data Model into my project.
[Model Output](/Views/assets/img/model.png)

2. I created three controllers in the Controller area of the project. I wrote my basic crud operations in these controller fields. I created category controller, customer controller and product controller fields and wrote backend codes.
[client controller page](/Views/assets/img/customercontroller.png)

3. The My Views area is the page that the user sees. I have frontend codes on this page. [product listing page](/Views/assets/img/productlisting.png)


