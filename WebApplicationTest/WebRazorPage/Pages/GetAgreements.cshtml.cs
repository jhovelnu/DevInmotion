using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebRazorPage.Models;

namespace WebRazorPage.Pages
{
    public class GetAgreementsModel : PageModel
    {
        private const string apiUrl = "https://localhost:44336/api/agreements";

        public List<AgreementModel> agreementsList { get; set; }

        public void OnGet()
        {
            agreementsList = GetData();        
        }

        #region internal Methods
        private List<AgreementModel> GetData()
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
                httpWebRequest.ContentType = "application/json; charset=utf-8";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var response = ReadResponse(httpResponse);
                return JsonConvert.DeserializeObject<List<AgreementModel>>(response);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo Data, error:{ex.Message}");
            }
        }

        protected static string ReadResponse(HttpWebResponse httpResponse)
        {
            if (httpResponse != null)
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            return string.Empty;
        }

        #endregion
    }
}
