using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoWebApi
{
    public static class ConsomeApi
    {
        public static async Task<List<Usuario>> GetUsuarios(string URI)
        {
            using (var client = new HttpClient())
            {
                using(var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<Usuario[]>(UsuarioJsonString).ToList();
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter o usuário : " + response.StatusCode);
                    }
                }
            }
        }

        public static async Task<Usuario> GetUsuarioById(string URI)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<Usuario>(UsuarioJsonString);
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter o usuário : " + response.StatusCode);
                    }
                }
            }
        }

        public static async void AddUsuario(string URI, Usuario usuario)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var serializedUsuario = JsonConvert.SerializeObject(usuario);
                    var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");

                    var result = await client.PostAsync(URI, content);

                }
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }


        public static async void UpdateUsuario(string URI, Usuario usuario)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var serializedUsuario = JsonConvert.SerializeObject(usuario);
                    var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await client.PutAsync(URI, content);
                    if (!responseMessage.IsSuccessStatusCode)
                    {
                        throw new Exception("Falha ao atualizar o usuário : " + responseMessage.RequestMessage);
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static async void DeleteUsuario(string URI, int codUsuario)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URI);

                    HttpResponseMessage responseMessage = await
                        client.DeleteAsync(String.Format("{0}/{1}", URI, codUsuario));

                    if(!responseMessage.IsSuccessStatusCode)
                    {
                        throw new Exception("Falha ao excluir o usuário : " + responseMessage.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
