using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.Models
{
    interface ICustomerProvider
    {
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> GetById(int id);
        IEnumerable<Customer> RemoveById(int id);
        IEnumerable<Customer> ChangeById(int id, string name, string phoneNumber);
        IEnumerable<Customer> CreateCustomer(string name, string phone);
        IEnumerable<Customer> AddContractor(int customerId, int contractorId, List<Contractor> cntList);
        IEnumerable<Customer> RemoveContractorById(int customerId, int contractorId);
        IEnumerable<Contractor> GetContractorList(int customerId);
    }
}
