using System;
using Api.Entity;
using RestSharp;

namespace Api.Services
{
    public class LioService
    {
        public LioResponse CriarPedido(LioOrder pedido)
        {
            var restClient = new RestClient("https://api.cielo.com.br/sandbox-lio/order-management/v1/orders");
            var request = new RestRequest(Method.POST);
            request.AddHeader("client-id", "GfUSILNTi3yF");
            request.AddHeader("merchant_id", "46770017-70ae-4ffd-bc99-6ebf22cdde4");
            request.AddHeader("access-token", "pndAvMo4D9kF");
            request.JsonSerializer = NewtonsoftJsonSerializer.Default;
            request.AddJsonBody(pedido);
            var response = restClient.Execute<LioResponse>(request);
            return response.Data ?? new LioResponse { Id = "nulo" };
        }

        public LioOrder GetPedido(string id)
        {
            var restClient = new RestClient("https://api.cielo.com.br/sandbox-lio/order-management/v1/orders/" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("client-id", "GfUSILNTi3yF");
            request.AddHeader("merchant_id", "46770017-70ae-4ffd-bc99-6ebf22cdde4");
            request.AddHeader("access-token", "pndAvMo4D9kF");
            var response = restClient.Execute<LioOrder>(request);
            return response.Data;
        }
    }

    public class LioResponse
    {
        public string Id { get; set; }
    }
}