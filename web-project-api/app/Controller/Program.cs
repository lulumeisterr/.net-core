using Microsoft.AspNetCore.Mvc;
using web_project_api.app.Model;
using web_project_api.app.TradeRepository;
/**
  Builder responsavel por
  ficar como listening para o recebimento de requisição
**/
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

TradeRepository tradeRepository = new TradeRepository();

app.MapPost("/trades", (Trade trade) => {
    tradeRepository.add(trade);
});

app.MapPut("/trades", (Trade trade) => {
    return tradeRepository.updateTrade(trade);
});

app.MapDelete("/trades/{tradeId}", ([FromRoute] int tradeId) => {
    tradeRepository.deleteTradeById(tradeId);
});

app.MapGet("/trades/{tradeId}", ([FromRoute] int tradeId) => {
    return tradeRepository.getTradeById(tradeId);
});

app.MapGet("/trades", ([FromQuery] DateTime startDate , [FromQuery] DateTime endDate) => {
    return tradeRepository.searchTradeByDate(startDate,endDate);
});

/**
 --- Exemplos 
**/

// Adicionando contexto no header no momento do request
app.MapGet("/getTradeByHeader", (HttpRequest request) => {
    return request.Headers["tradeId"].ToString();
});

// Adicionando info no header no recebimento do response
app.MapGet("/getheader", (HttpResponse response) => {
    response.Headers.Add("header","new header");
    return new {name = "success", header = "OK"};
});

app.Run();
