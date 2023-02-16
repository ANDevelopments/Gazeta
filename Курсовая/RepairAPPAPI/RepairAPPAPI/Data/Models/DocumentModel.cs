using System;

namespace RepairAPPAPI.Data.Models
{
    public class DocumentModel
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int OrderID { get; set; }
        public decimal Total { get; set; } 
        public DateTime DocumentDate { get; set; }
    }
}
