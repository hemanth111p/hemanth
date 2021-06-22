using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class TDSDataModel
    {
        private string tradeId;
        private string date;
        private decimal TradeValue;
        private string counterpartyId;

        public string GetTradeId() { return this.tradeId; }
        public string Getdate() { return this.date; }
        public decimal GetTradevalue() { return this.TradeValue; }
        public string GetcounterpartyId() { return this.counterpartyId; }
        public void SetTradeId(string value) { this.tradeId = value; }
        public void Setdate(string value) { this.date = value; }
        public void SetTradeValue(decimal value) { this.TradeValue = value; }
        public void SetCounterpartyId(string value) { this.counterpartyId=value; }

    }

}
