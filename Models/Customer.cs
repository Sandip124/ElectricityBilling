namespace ElectricityBilling.Models{

    public class Customer{
        public int id { get; set; }
        public int customer_id{get; set;}
        public string sc_no { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string customer_contact { get; set; }
        public string counter_name { get; set; }
        public string meter_no { get; set; }
        public string phase { get; set; }
        public int load { get; set; }
        public float due_amount{get; set;}
        public double initial_meter_reading { get; set; }
    }
}