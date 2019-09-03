using AddressEnrichmentApiTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AddressEnrichmentApiTests.Tests
{
    [TestClass]
    public class UnitTest1
    {
        RestService restService = new RestService();
        [TestMethod]
        public void GivenCorrectHeader_WhenGetRecognitionSent_ThenResponseContainAddress()
        {
            var request = restService.CreateRequeset("Home/GetRecognition?", Method.GET, "inputText", false);
            var content = restService.CreateClient().Execute(request).Content;

            Assert.AreEqual(true, content.Contains("Broadway"));
        }
        
        //you must replace the token :/
        [TestMethod]
        public void GivenCorrectInputStringWithBearerToken_WhenRequestSent_ThenRresponseReturnedJson()
        {
            var request = restService.CreateRequeset("api/values?", Method.GET, "inputString", true);
            var response = JObject.Parse(restService.CreateClient().Execute(request).Content);
            
            Assert.AreEqual(StringHelper.ResponseJson.ToString(), response.ToString());
        }
    }
}
