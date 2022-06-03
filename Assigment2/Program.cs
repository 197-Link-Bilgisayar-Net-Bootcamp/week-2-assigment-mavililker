// See https://aka.ms/new-console-template for more information
using Assigment2;
using Assignment2;
using static Assignment2.LSP.LSP;




Phone phone = new Iphone();

phone.Call();
((ITakePhoto)phone).TakePhoto();

phone = new Nokia();

phone.Call();


IProductRepos pr = new ProductRepo();
IProductRepos pr2 = new Other();
Service ps = new Service(pr);
Service ps2 = new Service(pr2);

Console.WriteLine(String.Join(",", ps.GetNames()));
Console.WriteLine(String.Join(",", ps2.GetNames()));

Manager manager = new Manager();

manager.Name = "İlker";
manager.LastName = "Mavili";

Employee employee = new Employee();

employee.Name = "İlker";
employee.LastName = "Mavili";

Console.WriteLine(manager.FullName);
Console.WriteLine(employee.FullName);