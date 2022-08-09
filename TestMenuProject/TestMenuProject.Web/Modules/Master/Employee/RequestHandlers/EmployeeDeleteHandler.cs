using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = TestMenuProject.Master.EmployeeRow;

namespace TestMenuProject.Master
{
    public interface IEmployeeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeDeleteHandler
    {
        public EmployeeDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}