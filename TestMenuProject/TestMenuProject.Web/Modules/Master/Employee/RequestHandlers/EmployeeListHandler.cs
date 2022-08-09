using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<TestMenuProject.Master.EmployeeRow>;
using MyRow = TestMenuProject.Master.EmployeeRow;

namespace TestMenuProject.Master
{
    public interface IEmployeeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeListHandler
    {
        public EmployeeListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}