using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace TestMenuProject.Master.Forms
{
    [FormScript("Master.Employee")]
    [BasedOnRow(typeof(EmployeeRow), CheckNames = true)]
    public class EmployeeForm
    {
        public String EmployeeName { get; set; }
        public Int32 CountryId { get; set; }
    }
}