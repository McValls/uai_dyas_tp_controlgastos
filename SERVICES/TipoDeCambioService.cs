using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SERVICES
{
    public class TipoDeCambioService
    {
        private readonly string BASE_URL = "https://dolarapi.com";
        private readonly string ENDPOINT_DOLAR_OFICIAL = "/v1/dolares/oficial";

        public decimal GetTipoDeCambioOficial()
        {
            var url = $"{BASE_URL}{ENDPOINT_DOLAR_OFICIAL}";
            
            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                
                // Extract "venta" value from JSON using regex
                Match match = Regex.Match(json, @"""venta""\s*:\s*([0-9]+\.?[0-9]*)");
                
                if (match.Success)
                {
                    decimal venta = decimal.Parse(match.Groups[1].Value);
                    return venta;
                }
                
                throw new Exception("No se pudo obtener el valor de venta del JSON");
            }
        }
    }
}
