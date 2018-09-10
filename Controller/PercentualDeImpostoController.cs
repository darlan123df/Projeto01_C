using Newtonsoft.Json.Linq;
using RestSharp;
using SDC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.Controller
{
    class PercentualDeImpostoController
    {
        public Ibpt importadadosIBPT(string codigoNcm)
        {
            Ibpt ibpt = new Ibpt();
            var client = new RestClient("https://apidoni.ibpt.org.br/api/v1/produtos?token=UDiCBAiy45WBs4XoXrs79l4gpjh0AJrLSHV8oCEOuwlrQeIHPOE0hF5Z3qnhIi3M&cnpj=05605430000150&codigo="+ codigoNcm +"&uf=DF&ex=0&descricao=&unidadeMedida=&valor=0.00&gtin=%22%22");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "960ae967-a07f-4651-a7b4-c3b093fb0b19");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            JObject importar = JObject.Parse(response.Content);

            ibpt.ibptImpostoFederal = Double.Parse(importar["Nacional"].ToString());
            ibpt.ibptImpostoEstadual = Double.Parse(importar["Estadual"].ToString());
            ibpt.ibptImpostoMunicipal = Double.Parse(importar["Municipal"].ToString());

            return ibpt;
        }
    }
}
