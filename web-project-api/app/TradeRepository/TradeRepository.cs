using web_project_api.app.Model;
namespace web_project_api.app.TradeRepository
{
    public class TradeRepository
    {
        public TradeRepository() {}

        public static List<Trade> trades;

        public void add (Trade trade) {
            if(trades == null) {
                trades = new List<Trade>();
            }
            trades.Add(trade);
        }

        public Trade getTradeById(int tradeId) {
            return trades.Where(t => t.TradeId == tradeId).FirstOrDefault();
        }

        public IEnumerable<Trade> searchTradeByDate(DateTime dateStart, DateTime endDate) {
            return trades.Where(t => t.TradingDate >= dateStart && t.TradingDate <= endDate);
        }

        public Trade updateTrade(Trade trade) {
            var tradeSaved = getTradeById(trade.TradeId);
            tradeSaved.TradeStatusCode = trade.TradeStatusCode;
            tradeSaved.TradingDate = trade.TradingDate;
            return tradeSaved;
        }

        public void deleteTradeById (int tradeId) {
             var tradeSaved = getTradeById(tradeId);
             trades.Remove(tradeSaved);
        }
    }
}