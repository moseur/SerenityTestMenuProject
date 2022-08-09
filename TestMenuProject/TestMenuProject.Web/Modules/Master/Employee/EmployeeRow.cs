using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace TestMenuProject.Master
{
    [ConnectionKey("Default"), Module("Master"), TableName("[test].[Employee]")]
    [DisplayName("Employee"), InstanceName("Employee")]
    [ReadPermission("Master:Employee")]
    [ModifyPermission("Master:Employee")]
    public sealed class EmployeeRow : Row<EmployeeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Employee Id"), Identity, IdProperty]
        public Int32? EmployeeId
        {
            get => fields.EmployeeId[this];
            set => fields.EmployeeId[this] = value;
        }

        [DisplayName("Employee Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public String EmployeeName
        {
            get => fields.EmployeeName[this];
            set => fields.EmployeeName[this] = value;
        }

        [DisplayName("Country"), NotNull, ForeignKey("[test].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryName")]
        [LookupEditor(typeof(CountryRow), InplaceAdd = true)]
        public Int32? CountryId
        {
            get => fields.CountryId[this];
            set => fields.CountryId[this] = value;
        }

        [DisplayName("Country Country Name"), Expression("jCountry.[CountryName]")]
        public String CountryCountryName
        {
            get => fields.CountryCountryName[this];
            set => fields.CountryCountryName[this] = value;
        }

        public EmployeeRow()
            : base()
        {
        }

        public EmployeeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field EmployeeId;
            public StringField EmployeeName;
            public Int32Field CountryId;

            public StringField CountryCountryName;
        }
    }
}
