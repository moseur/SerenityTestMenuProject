using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace TestMenuProject.Master.Forms
{
    [FormScript("Master.Country")]
    [BasedOnRow(typeof(CountryRow), CheckNames = true)]
    public class CountryForm
    {
        public String CountryName { get; set; }
    }
}