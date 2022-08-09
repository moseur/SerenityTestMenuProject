
namespace TestMenuProject.Master
{
    using Serenity.Extensions.Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using TestMenuProject.Administration.Entities;
    using System;
    using System.Collections.Generic;   

    [Report("Employee.EmployeeDetailsReport")]
    [ReportDesign(MVC.Views.Master.Employee.EmployeeDetailsReport)]
    //[RequiredPermission(PermissionKeys.General)]
    public class PurchaseReport : IReport, ICustomizeHtmlToPdf
    {
        protected ISqlConnections SqlConnections { get; }
        public PurchaseReport(ISqlConnections sqlConnections)
        {
            SqlConnections = sqlConnections;
        }
        public Int64 EmployeeID { get; set; }

        public object GetData()
        {
            var data = new EmployeeDetailsReportData();

            using (var connection = SqlConnections.NewFor<EmployeeRow>())
            {
                var o = EmployeeRow.Fields;

                data.employee = connection.TryFirst<EmployeeRow>(q => q
                    .SelectTableFields()
                    .Select(o.EmployeeName)
                    .Select(o.CountryCountryName)
                    .Where(o.EmployeeId == this.EmployeeID));
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            // options.MarginsAll = "2cm";
        }
    }

    public class EmployeeDetailsReportData
    {
        public EmployeeRow employee { get; set; }
    }
}