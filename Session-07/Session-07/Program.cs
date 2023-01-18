// See https://aka.ms/new-console-template for more information
using Session_07;

Console.WriteLine("Hello, World!");
ActionRequest request = new ActionRequest();
ActionResponse response = new ActionResponse();
ActionResolver resolver = new ActionResolver();
response = resolver.Execute(request);

