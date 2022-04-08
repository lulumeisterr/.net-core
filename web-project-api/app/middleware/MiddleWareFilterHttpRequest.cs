using web_project_api.app.Repositorys;

namespace web_project_api.app.middleware;

    public class MiddleWareFilterHttpRequest {
    private readonly RequestDelegate _next;

    private readonly ITradeRepository _tradeRepository;

    /**
        Reponsavel por realizar manipulação de requisições HTTP 
        e chamar o próximo middleware do pipeline;
    **/
    public MiddleWareFilterHttpRequest (RequestDelegate next, ITradeRepository tradeRepository) {
        _next = next;
        _tradeRepository = tradeRepository;
    }
    
    public async Task InvokeAsync(HttpContext context) {
        Console.WriteLine("\n\r----- Iniciando meu 1 middleware -----\n\r");
        int getTradesQtd = _tradeRepository.GetAllTrades().Count();
        if (getTradesQtd >= 3) {
            if (context.Request.Path.StartsWithSegments("/trades") && context.Request.Method == "POST") {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Limite de requisição atiginda");
            }
        } else {
            await _next(context);
            Console.WriteLine("\n\r----- Finalizando meu 1 middleware -----\n\r");
        }
      }
}
