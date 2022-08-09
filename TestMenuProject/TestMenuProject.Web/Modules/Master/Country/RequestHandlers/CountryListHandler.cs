using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<TestMenuProject.Master.CountryRow>;
using MyRow = TestMenuProject.Master.CountryRow;

namespace TestMenuProject.Master
{
    public interface ICountryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CountryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICountryListHandler
    {
        public CountryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}