using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace RazorPage
{
    internal class SampleAsyncPageFilter : IFilterMetadata
    {
        private IConfiguration configuration;

        public SampleAsyncPageFilter(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}