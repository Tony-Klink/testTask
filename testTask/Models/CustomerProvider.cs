using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testTask.Models
{
    public class CustomerProvider : ICustomerProvider
    {
        private static List<Customer> _customerList = new List<Customer>();

        /// <summary>
        /// Create new Customer object and add it to list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public IEnumerable<Customer> CreateCustomer(string name, string phone)
        {
            _customerList.Add(new Customer(name, phone));
            return _customerList;            
        }

        /// <summary>
        /// Returns the number of Customer objects in list
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _customerList.Count;
        }

        /// <summary>
        /// Get list of Customer objects
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAll()
        {
            return _customerList;
        }

        /// <summary>
        /// Get Customer object from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Customer> GetById(int id)
        {
            List<Customer> selectedCustomer = new List<Customer>();
            selectedCustomer.Add(_customerList[id]);
            return selectedCustomer;
        }

        /// <summary>
        /// Remove Customer object from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Customer> RemoveById(int id)
        {
            _customerList.RemoveAt(id);
            return _customerList;
        }

        /// <summary>
        /// Change Customer object parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public IEnumerable<Customer> ChangeById(int id, string name, string phoneNumber)
        {
            List<Customer> selectedCustomer = new List<Customer>();
            selectedCustomer.Add(_customerList[id]);
            if (name != "")
            {
                selectedCustomer[0].ChangeName(name);
            }
            if (phoneNumber != "")
            {
                selectedCustomer[0].ChangePhoneNumber(phoneNumber);
            }
            return selectedCustomer;
        }

        /// <summary>
        /// Add Contractor to Customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="contractorId"></param>
        /// <param name="cntList">list of contractors</param>
        /// <returns></returns>
        public IEnumerable<Customer> AddContractor(int customerId, int contractorId, List<Contractor> cntList)
        {

            _customerList[customerId].AddContractor(contractorId, cntList);
            return _customerList;
        }

        /// <summary>
        /// Remove Contractor from Customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="contractorId"></param>
        /// <returns></returns>
        public IEnumerable<Customer> RemoveContractorById(int customerId, int contractorId)
        {
            _customerList[customerId].RemoveContractor(contractorId);
            return _customerList;
        }

        /// <summary>
        /// Return Contractor list of Customer object
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Contractor> GetContractorList(int id)
        {
            return _customerList[id].GetContractorList();
        }

        /// <summary>
        /// Get the number of Contractor objects of Customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public int CountContractors(int customerId)
        {
            return _customerList[customerId].CountContractors();
        }
    }
}