using AddressEnrichmentApiTests.Helpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressEnrichmentApiTests
{
    class RestService
    {
        public RestClient CreateClient() => new RestClient(StringHelper.UrlCoreAddress);

        public RestRequest CreateRequeset(string requestResource, RestSharp.Method metod, string parameterType, bool tokenBearer)
        {
            var request = new RestRequest(requestResource, metod);
            request.AddParameter(parameterType, StringHelper.RequestParameter);
            if (tokenBearer)
            {
                request.AddHeader("Authorization", $"Bearer {StringHelper.BearerToken}");
            }
            return request;
        }
    }
}
