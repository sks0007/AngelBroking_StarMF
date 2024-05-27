namespace Mfund.Model
{
    public class OrderModifyOrder
    {
        public string variety { get; set; }

        public int orderid { get; set; }

        public string ordertype { get; set; }

        public string producttype { get; set; }

        public string duration { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }

        public string tradingsymbol { get; set; }

        public string symboltoken { get; set; }

        public string exchange { get; set; }
    }
}
