using GestmetModelsInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsGlobal.Services
{
    public class VPosteRepository : IRepositoryGlobal<VPoste>
    {
        public int Create(VPoste T)
        {
            throw new NotImplementedException();
        }

        public bool CreateNew(VPoste T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VPoste> GetAll()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("VPoste").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<VPoste[]>(json);
            }
        }

        public VPoste GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, VPoste T)
        {
            throw new NotImplementedException();
        }
    }
}
