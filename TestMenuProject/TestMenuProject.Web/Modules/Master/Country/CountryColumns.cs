using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace TestMenuProject.Master.Columns
{
    [ColumnsScript("Master.Country")]
    [BasedOnRow(typeof(CountryRow), CheckNames = true)]
    public class CountryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CountryId { get; set; }
        [EditLink]
        public String CountryName { get; set; }
    }
}