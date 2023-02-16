using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepairAPPAPI.Data.Logic
{
    public class ServLogic : APILogic<ServModel>
    {
        public ServLogic()
        {
            BaseUri = "api/Servs";
        }
    }
}
