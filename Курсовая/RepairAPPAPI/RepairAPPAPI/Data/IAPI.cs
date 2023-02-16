using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RepairAPPAPI.Data
{
    public interface IAPI<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<Uri> Create(T entity);
        Task<T> Update(T entity);
        Task<HttpStatusCode> Delete(int id);
    }
}
