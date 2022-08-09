using Serenity.Navigation;
using MyPages = TestMenuProject.Master.Pages;

[assembly: NavigationLink(int.MaxValue, "Master/Country", typeof(MyPages.CountryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Master/Employee", typeof(MyPages.EmployeeController), icon: null)]