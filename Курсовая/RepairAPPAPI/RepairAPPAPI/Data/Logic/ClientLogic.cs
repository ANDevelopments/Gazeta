using RepairAPPAPI.Data.Models;

namespace RepairAPPAPI.Data.Logic
{
    public class ClientLogic : APILogic<ClientModel>
    {
        public ClientLogic()
        {
            BaseUri = "api/Clients";
        }
    }
}
