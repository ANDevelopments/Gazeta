using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepairAPPAPI.Data.Logic
{
    public class OrdersLogic : APILogic<OrdersModel>
    {
        public OrdersLogic()
        {
            BaseUri = "api/Orders";
        }
    }
}
