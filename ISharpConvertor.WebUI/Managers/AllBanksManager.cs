using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using ISharpConvertor.UIModels;
namespace ISharpConvertor.WebUI.Managers
{
    public class AllBanksManager
    {

        public async Task<List<BankModel>> GetBankAsyncById(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<BankModel>>
                (
                    await httpClient.GetStringAsync("https://localhost:44300/api/allbanks/"+id)
                );
            }}
        public async Task<List<AdressModel>> GetBankAsyncByCity(string city, string country)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<AdressModel>>
                (
                    await httpClient.GetStringAsync("https://localhost:44300/api/getbankbycity$city=" + city + "$country="+country)
                );
            }
        }
            public async Task<List<AdressModel>> GetAllAdress()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<AdressModel>>
                (
                    await httpClient.GetStringAsync("https://localhost:44300/api/adress/")
                );
            }
        }
        public async Task<List<BankModel>> GetAllBankAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<BankModel>>
                (
                    await httpClient.GetStringAsync("https://localhost:44300/api/allbanks/" )
                );
            }
        }
        public async Task<List<BankModel>> GetBankAsync(string name)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<BankModel>>
                (
                    await httpClient.GetStringAsync("https://localhost:44300/api/values/" + name)
                );
            }
        }
        
            public async Task<List<AdressModel>> GetAdressAsyncById(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<AdressModel>>
                (
                    await httpClient.GetStringAsync("https://localhost:44300/api/adress/"+id)
                );
            }
        }
        
       
    }
}