using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = TestMenuProject.Master.EmployeeRow;

namespace TestMenuProject.Master.Endpoints
{
    [Route("Services/Master/Employee/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class EmployeeController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IEmployeeSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IEmployeeSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IEmployeeDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IEmployeeRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IEmployeeListHandler handler)
        {
            return handler.List(connection, request);
        }

        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IEmployeeListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.EmployeeColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "EmployeeList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}