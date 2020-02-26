using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace WebApiBasket.Services.Repository
{
    public class ApiRequestHelper
    {
        public static async Task<T> GetJsonRequest<T>(string requestUrl)
        {
            try
            {
                var apiRequest = WebRequest.Create(requestUrl);
                var apiResponse = (HttpWebResponse)apiRequest.GetResponse();

                if (apiResponse.StatusCode == HttpStatusCode.OK)
                {
                    string jsonOutput;
                    using (var sr = new StreamReader(apiResponse.GetResponseStream()))
                        jsonOutput = await sr.ReadToEndAsync().ConfigureAwait(false);

                    var jsResult = JsonConvert.DeserializeObject<T>(jsonOutput);

                    if (jsResult != null)
                        return jsResult;
                    else
                        return default(T);
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                // Log error here.

                return default(T);
            }
        }
        public static T GetXmlRequest<T>(string requestUrl)
        {
            try
            {
                var apiRequest = WebRequest.Create(requestUrl);
                var apiResponse = (HttpWebResponse) apiRequest.GetResponse();

                if (apiResponse.StatusCode == HttpStatusCode.OK)
                {
                    string xmlOutput;
                    using (var sr = new StreamReader(apiResponse.GetResponseStream()))
                        xmlOutput = sr.ReadToEnd();

                    var xmlSerialize = new XmlSerializer(typeof(T));

                    var xmlResult = (T) xmlSerialize.Deserialize(new StringReader(xmlOutput));

                    if (xmlResult != null)
                        return xmlResult;
                    else
                        return default(T);
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                // Log error here.
                return default(T);
            }
        }
    }
}