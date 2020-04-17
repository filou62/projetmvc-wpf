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
    public class JDTRepository : IRepositoryGlobal<JournalDesTravaux>
    {
        public int Create(JournalDesTravaux entity)
        {
            // utiliser dans le using à la place de "= new "une méthode qui générera les lignes htppclient utilisé un peu partout de manière répétitive
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(entity);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync("JDT", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return int.Parse(json);
            }
        }

        public bool CreateNew(JournalDesTravaux T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //string jsonContent = JsonConvert.SerializeObject(entity);
                    //HttpContent httpContent = new StringContent(jsonContent);
                    //httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                    HttpResponseMessage httpResponseMessage = httpClient.DeleteAsync("JDT/" + id).Result;
                    httpResponseMessage.EnsureSuccessStatusCode();

                    //string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    //return int.Parse(json);
                }
            }
        }

        public IEnumerable<JournalDesTravaux> GetAll()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("JDT").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<JournalDesTravaux[]>(json);
            }
        }

        public JournalDesTravaux GetOne(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("JDT/"+id).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<JournalDesTravaux>(json);
            }
        }

        public void Update(int id, JournalDesTravaux entity)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:49262/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(entity);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PutAsync("JDT/"+id, httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                //string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                //return int.Parse(json);
            }
        }
    }
}
