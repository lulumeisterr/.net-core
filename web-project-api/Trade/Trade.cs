namespace web_project_api.Trade
{
    public class Trade
    {
        public static List<Trade> trades = new List<Trade>();
        private int tradeId;
        private string tradingDate;
        private string tradeStatusCode;
        public Trade(int tradeId, string tradingDate, string tradeStatusCode) {
            this.tradeId = tradeId;
            this.tradingDate = tradingDate;
            this.tradeStatusCode = tradeStatusCode;
        }

        public Trade() {}

//getset
        public string TradingDate { 
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