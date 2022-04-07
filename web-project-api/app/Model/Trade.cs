namespace web_project_api.app.Model
{
    public class Trade
    {
        private int tradeId;
        private DateTime tradingDate;
        private string tradeStatusCode;
        public Trade(int tradeId, DateTime tradingDate, string tradeStatusCode) {
            this.tradeId = tradeId;
            this.tradingDate = tradingDate;
            this.tradeStatusCode = tradeStatusCode;
        }

        public Trade() {}

//getset
        public DateTime TradingDate { 
            get => tradingDate; 
            set => tradingDate = value; 
        }

        public string TradeStatusCode { 
            get => tradeStatusCode; 
            set => tradeStatusCode = value; 
        }

        public int TradeId { 
            get => tradeId; 
            set => tradeId = value; 
        }

        public override string ToString()
        {
            return tradeId + tradeStatusCode + tradingDate;
        }

    }
}