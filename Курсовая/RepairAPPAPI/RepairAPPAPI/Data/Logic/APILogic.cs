using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RepairAPPAPI.Data.Logic
{
    public class APILogic<T> : IDisposable
    {
        public string BaseUri { get; set; }

        public API API { get; }

        public APILogic()
        {
            API = new API();
        }
        public void Dispose()
        {
            API.HttpClient.Dispose();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IEnumerable<T> list = null;
            HttpResponseMessage response = await API.HttpClient.GetAsync($"{API.BaseUri}/{BaseUri}");
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }

            return list;
        }

        public async Task<T> Get(int id)
        {
            T item = default;
            HttpResponseMessage response = await API.HttpClient.GetAsync($"{API.BaseUri}/{BaseUri}/{id}");
            if (response.IsSuccessStatusCode)
            {
                item = await response.Content.ReadAsAsync<T>();
            }

            return item;
        }

        public async Task<Uri> Create(T entity)
        {
            HttpResponseMessage response = await API.HttpClient.PostAsJsonAsync(BaseUri, entity);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public async Task<T> Update(int id, T entity)
        {
            HttpResponseMessage response = await API.HttpClient.PutAsJsonAsync($"{API.BaseUri}/{BaseUri}/{id}", entity);
            response.EnsureSuccessStatusCode();
            entity = await response.Content.ReadAsAsync<T>();
            return entity;
        }

        public async Task<HttpStatusCode> Delete(int id)
        {
            HttpResponseMessage response = await API.HttpClient.DeleteAsync($"{API.BaseUri}/{BaseUri}/{id}");
            return response.StatusCode;
        }
    }
}
