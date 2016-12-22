using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.Models
{
    interface IContractorProvider
    {
        IEnumerable<Contractor> GetAll();
        IEnumerable<Contractor> GetById(int id);
        IEnumerable<Contractor> RemoveById(int id);
        IEnumerable<Contractor> CreateContractor(string name, string phone, string email);
        IEnumerable<Contractor> ChangeById(int id, string name, string phoneNumber, string email, int stateValue);
    }
}
