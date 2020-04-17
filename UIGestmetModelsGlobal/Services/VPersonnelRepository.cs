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
    public class VPersonnelRepository : IRepositoryGlobal<Personnel>
    {
        public int Create(Personnel T)
        {
            throw new NotImplementedException();
        }

        public bool CreateNew(Personnel T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personnel> GetAll()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("VPersonnel").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Personnel[]>(json);
            }
        }

        public Personnel GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Personnel T)
        {
            throw new NotImplementedException();
        }
    }
}
