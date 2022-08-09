using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace TestMenuProject.Master.Columns
{
    [ColumnsScript("Master.Employee")]
    [BasedOnRow(typeof(EmployeeRow), CheckNames = true)]
    public class EmployeeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 EmployeeId { get; set; }
        [EditLink]
        public String EmployeeName { get; set; }
        public String CountryCountryName { get; set; }
    }
}