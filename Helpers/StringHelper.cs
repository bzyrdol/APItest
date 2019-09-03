using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace AddressEnrichmentApiTests.Helpers
{
    public class StringHelper
    {
        //it should be a separate class with core settings
        public readonly static string UrlCoreAddress = "http://addressenrichment.azurewebsites.net/";
        // parameters should be generated automatically or downloaded
        public readonly static string RequestParameter = "Scaleworks%20Inc%2C%20118%20Broadway%20Suite%20627%20San%20Antonio%2C%20TX%2078205";
        // This token is set rigidly and will not work. The token should be generated in a separate method or downloaded during the test
        public readonly static string BearerToken = "ntfwaaLM5W3l8zN-qxTGnJyPnADt8VzkvSQrlBvAbHH0D3wQCYrlE6Ez3f4WTIgDw05NGJXgOrVZUSAJ-3bOmEE0srUCIBwr85mjkD4OANJxptUi8Nn5ZbtykZJCSyGzH03NWvTqoyeyJCq7WiTQVbYCRJFmzyT3thEkCxiNtC9fO290ddvlnuoqHTuz5sPxBoY75ZAMP6mpP2JzGWa9r3pf5XZMLm7-Stv9sLNaRDbZYjgEFCBHr5BHkrt4TFYa";

        public static JObject ResponseJson = JObject.Parse(File.ReadAllText(@"..\..\..\AddressEnrichmentApiTests\Helpers\Response.json"));
      
    }
}
