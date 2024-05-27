namespace Mfund.Model
{
    public class OrderPlaceOrder
    {
        public string variety { get; set; }

        public string tradingsymbol { get; set; }

        public string symboltoken { get; set; }

        public string transactiontype { get; set; }

        public string exchange { get; set; }

        public string ordertype { get; set; }

        public string producttype { get; set; }

        public string duration { get; set; }

        public decimal price { get; set; }

        public int squareoff { get; set; }

        public int stoploss { get; set; }

        public int quantity { get; set; }
    }
}
