using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testTask.Models
{
    public class Customer
    {
        private string Name { get; set; }
        private string PhoneNumber { get; set; }
        private List<Contractor> contractorList;

        /// <summary>
        /// Create new Customer object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        public Customer(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.contractorList = new List<Contractor>();
        }

        /// <summary>
        /// Get Name parameter of Customer
        /// </summary>
        /// <returns>string "Name"</returns>
        public string GetName()
        {
            return this.Name;
        }

        /// <summary>
        /// Get PhoneNumber parameter of Customer
        /// </summary>
        /// <returns></returns>
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        /// <summary>
        /// Change Name parameter of Customer
        /// </summary>
        /// <param name="name"></param>
        public void ChangeName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Change PhoneNumber parameter of Customer
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void ChangePhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Add new Contractor to Customer
        /// </summary>
        /// <param name="contractorId">id of Contractor</param>
        /// <param name="cntList">List of Contractors</param>
        public void AddContractor(int contractorId, List<Contractor> cntList)
        {
            contractorList.Add(cntList[contractorId]);
        }

        /// <summary>
        /// Remone Contractor from Customer by id
        /// </summary>
        /// <param name="id">Contractor's id</param>
        public void RemoveContractor(int id)
        {
            contractorList.RemoveAt(id);
        }

        /// <summary>
        /// Returns list of Customer contractors
        /// </summary>
        /// <returns></returns>
        public List<Contractor> GetContractorList()
        {
            contractorList = contractorList.Distinct().ToList();
            return contractorList;
        }

        /// <summary>
        /// Returns the number of contractors
        /// </summary>
        /// <returns></returns>
        public int CountContractors()
        {
            return contractorList.Count;
        }
    }
}