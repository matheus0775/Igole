using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Igole.Model
{
  public class Server
    {
        private string endpoint = "http://25.38.4.243:3333/CadastrarProdutos";

        public List<ModCardapio> GetAll()
        {
            using (var produto = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                var json = produto.GetStringAsync(endpoint).Result;
                var Lista = JsonConvert.DeserializeObject<List<ModCardapio>>(json).ToList();
                return Lista;
            }
        }

        public void Add(ModCardapio cardapio)
        {
            using (var produto = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                var dados = JsonConvert.SerializeObject(cardapio);
                var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
                request.Content = new StringContent(dados, Encoding.UTF8, "application/json");
                var result = produto.SendAsync(request).Result;
                if (result.IsSuccessStatusCode)
                {

                }
            }
        }


        public void Update(ModCardapio cardapio)
        {
            using (var produto = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                var dados = JsonConvert.SerializeObject(cardapio);
                var request = new HttpRequestMessage(HttpMethod.Put, string.Format("{0}/{1}", endpoint, cardapio._id));
                Console.WriteLine(dados);
                request.Content = new StringContent(dados, Encoding.UTF8, "application/json");
                var result = produto.SendAsync(request).Result;
                Console.WriteLine("teste");

                
    
            }
        }


        public void Delete(ModCardapio cardapio)
        {
            using (var produto = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                var dados = JsonConvert.SerializeObject(cardapio);
                var request = new HttpRequestMessage(HttpMethod.Delete, string.Format("{0}/{1}", endpoint, cardapio._id));
                request.Content = new StringContent(dados, Encoding.UTF8, "application/json");
                var result = produto.SendAsync(request).Result;
            }

            
        }
    }
}
