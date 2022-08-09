using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<TestMenuProject.Master.EmployeeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = TestMenuProject.Master.EmployeeRow;

namespace TestMenuProject.Master
{
    public interface IEmployeeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeSaveHandler
    {
        public EmployeeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}