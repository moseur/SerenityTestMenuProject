using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace TestMenuProject.Master
{
    [ConnectionKey("Default"), Module("Master"), TableName("[test].[Country]")]
    [DisplayName("Country"), InstanceName("Country")]
    [ReadPermission("Master:Country")]
    [ModifyPermission("Master:Country")]
    [LookupScript("Master.Country")]
    public sealed class CountryRow : Row<CountryRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Country Id"), Identity, IdProperty]
        public Int32? CountryId
        {
            get => fields.CountryId[this];
            set => fields.CountryId[this] = value;
        }

        [DisplayName("Country Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public String CountryName
        {
            get => fields.CountryName[this];
            set => fields.CountryName[this] = value;
        }

        public CountryRow()
            : base()
        {
        }

        public CountryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CountryId;
            public StringField CountryName;
        }
    }
}
