using System;

namespace RepairAPPAPI.Data.Models
{
    public class OrdersModel
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string ServiceName { get; set; }
        public string Descript { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime Execution { get; set; }
        public string Progress { get; set; }
    }
}
