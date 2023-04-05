using Client.Models;
using Client.Services.Interface;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public class CatService : HttpClient, ICatService
    {
        private readonly CatServiceSettings _settings;
        public CatService(IOptions<CatServiceSettings> settings)
        {
            _settings = settings.Value;
            BaseAddress = new Uri(_settings.BaseUrl);
        }

        public CatService(IOptions<CatServiceSettings> settings, HttpMessageHandler httpMessageHandler) : base(httpMessageHandler)
        {
            _settings = settings.Value;
            BaseAddress = new Uri(_settings.BaseUrl);
        }
        public async Task<FactViewModel> Get()
        {
            try
            {
                var response = await GetAsync(BaseAddress + "fact");
                string apiResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<FactViewModel>(apiResponse);

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }
    }
}
