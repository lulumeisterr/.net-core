using web_project_api.app.Model;
namespace web_project_api.app.Repositorys
{
    public interface ITradeRepository
    {
         void add (Trade trade);
         Trade updateTrade(Trade trade);
         void deleteTradeById (int tradeId);
         Trade getTradeById(int tradeId);
         IEnumerable<Trade> searchTradeByDate(DateTime dateStart, DateTime endDate);

         IEnumerable<Trade> getAllTrades();
    }
}