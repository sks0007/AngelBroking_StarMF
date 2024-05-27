namespace Mfund.Model
{
    public class OrderIndividualOrderStatus
    {
        public string variety {  get; set; }    

        public string ordertype { get; set; }   

        public string producttype { get; set; } 

        public string duration { get; set; }    

        public decimal price { get; set; }  

        public int triggerprice { get; set; }

        public int quantity { get; set; }   

        public int disclosedquantity { get; set; }  

        public  int squareoff {  get; set; }    

        public int stoploss { get; set; }   

        public int trailingstoploss { get; set; }   

        public string tradingsymbol { get; set; }

        public string transactiontype { get; set; } 

        public string exchange {  get; set; }   

        public  int symboltoken { get; set; }   

        public string instrumenttype { get; set; }  

        public int strikeprice { get; set; }    

        public string optiontype {  get; set; }

        public DateOnly expirydate { get; set; }    

        public int lotsize {  get; set; }   

        public int cancelsize { get; set; } 

        public decimal averageprice { get; set;}

        public int filledshares {  get; set; }

        public int unfilledshares { get; set; }

        public int orderid { get; set; }    

        public string text { get; set; }    

        public string status { get; set; }  

        public string orderstatus { get; set; } 

        public DateTime updatetime { get; set; }

        public DateOnly exchtime { get; set; }  

        public DateTime exchorderupdatetime { get; set; }

        public string fillid { get; set; }  

        public TimeOnly filltime { get; set; }  

        public int parentorderid {  get; set; } 

        public string ordertag { get; set; }    

        public string uniqueorderid { get; set; }   
    }
}
