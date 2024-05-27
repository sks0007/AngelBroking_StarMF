namespace Mfund.Model
{
    public class BrokerageCalculator
    {
        public string product_type {  get; set; }   

        public string transaction_type { get; set; }    

        public int quantity { get; set; }   

        public int price { get; set; }  

        public string exchange { get; set; }    

        public string symbol_name { get; set; } 

        public int token { get; set; }  
    }
}
