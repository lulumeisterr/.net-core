using Microsoft.AspNetCore.Mvc;
using web_project_api.Trade;
/**
  Builder responsavel por
  ficar como listening para o recebimento de requisição
**/
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/trade", (Trade trade) => {
    Trade.trades.Add(trade);
    return new {TradeId = trade.TradeId , 
                TradeStatusCode = trade.TradeStatusCode, 
                TradingDate = trade.TradingDate};
});

app.MapGet("/getTrade/{tradeId}", ([FromRoute] int tradeId) => {
    return Trade.trades.FirstOrDefault(t => t.TradeId == tradeId);
});

app.MapGet("/getTrade", ([FromQuery] DateTime dateEnd) => {
    return Trade.trades.Where(t => t.TradingDate >= dateEnd);
});

// Alterando header de resposta
app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("header","new header");
    return new {name = "header", header = "lulumeisterr"};
});


app.Run();
