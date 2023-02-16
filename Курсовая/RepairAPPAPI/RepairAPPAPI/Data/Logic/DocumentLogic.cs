using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepairAPPAPI.Data.Logic
{
    public class DocumentLogic : APILogic<DocumentModel>
    {
        public DocumentLogic()
        {
            BaseUri = "api/Documents";
        }
    }
}
