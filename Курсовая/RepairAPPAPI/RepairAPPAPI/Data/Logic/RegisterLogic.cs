using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepairAPPAPI.Data.Logic
{
    public class RegisterLogic : APILogic<RegisterModel>
    {
        public RegisterLogic()
        {
            BaseUri = "api/Registers";
        }
    }
}
