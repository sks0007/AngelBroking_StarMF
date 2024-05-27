namespace Mfund.Model
{
    public class GTTModifyRule
    {
        public int id { get; set; }
        public string symboltoken { get; set; }
        public string exchange { get; set; }

        public int price { get; set; }

        public int qty { get; set; }

        public int triggerprice { get; set; }

        public int disclosedqty { get; set; }

        public int timeperiod { get; set; }
    }
}
