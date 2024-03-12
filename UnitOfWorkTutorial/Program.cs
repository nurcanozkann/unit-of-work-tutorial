// See https://aka.ms/new-console-template for more information
using UnitOfWorkTutorial.Data.UnitOfWork;
using UnitOfWorkTutorial.Data;
using UnitOfWorkTutorial.Entities;

UnitOfWork unitOfWork = new UnitOfWork(new UoWContext());
unitOfWork.DepartmentRepository.Add(new Department
{
    Location = "İstanbul",
    Name = "Bilgi İşlem"
});

unitOfWork.EmployeeRepository.Add(new Employee
{
    DepartmentId = 1,
    FirstName = "Nurcan",
    LastName = "Özkan",
    EmailAddress = "nurcan.ozkan@gmail.com",
    Location = "İstanbul",
});

unitOfWork.Commit();
Console.WriteLine("Hello, World!");
