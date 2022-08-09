using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMenuProject.Migrations.DefaultDB
{
	[Migration(20220809100001)]
	public class DefaultDB_20220809_100001_AllTable : Migration
	{
        public override void Up()
        {
            Create.Schema("test");

            Create.Table("Country").InSchema("test")
                .WithColumn("CountryId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("CountryName").AsString(200).NotNullable();

            Create.Table("Employee").InSchema("test")
                .WithColumn("EmployeeId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("EmployeeName").AsString(200).NotNullable()
                .WithColumn("CountryId").AsInt32().NotNullable()
                    .ForeignKey("FK_Country_CountryId", "test", "Country", "CountryId");
        }

        public override void Down()
        {
        }
    }
}
