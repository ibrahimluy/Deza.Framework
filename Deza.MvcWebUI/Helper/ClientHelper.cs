using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Deza.Stone;
using System.Threading.Tasks;
using Deza.Models.Dtos;

namespace Deza.MvcWebUI.Helper
{
    public class ClientHelper
    {
        public void Login()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var user = new UserDto()
                {
                    email = "ibrahimluy@hotmail.com",
                    password = "test123456",
                    firstName = "İbrahim",
                    lastName = "LÜY"
                };

                var tempResult = httpClient.PostJsonAsync<TokenDto>("http://testkitbis.gsb.gov.tr/api/Auth/login", user);

                tempResult.Wait();

                var result = tempResult.Result.token;

            }
        }

        public void Get(string token)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var tempResult = httpClient.GetJsonAsync<List<ReportDto>>("http://testkitbis.gsb.gov.tr/api/genc/getreports");

                var result = tempResult.Result;
            }
        }

    }
}
