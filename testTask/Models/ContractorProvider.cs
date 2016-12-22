using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testTask.Models
{
    public class ContractorProvider : IContractorProvider
    {
        private static List<Contractor> _contractorList = new List<Contractor>();

        /// <summary>
        /// Create new Contractor object and append it to list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public IEnumerable<Contractor> CreateContractor(string name, string phone, string email)
        {
            _contractorList.Add(new Contractor(name, phone, email));
            return _contractorList;
        }

        /// <summary>
        /// Returns the number of Contractor objects
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _contractorList.Count;
        }

        /// <summary>
        /// Get list of Contractor objects
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Contractor> GetAll()
        {
            return _contractorList;
        }

        /// <summary>
        /// Get one Contractor object from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>list with one Contractor object</returns>
        public IEnumerable<Contractor> GetById(int id)
        {
            List<Contractor> selectedContractor = new List<Contractor>();
            selectedContractor.Add(_contractorList[id]);
            return selectedContractor;
        }

        /// <summary>
        /// Remove Contractor object from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Contractor> RemoveById(int id)
        {
            _contractorList.RemoveAt(id);
            return _contractorList;
        }

        /// <summary>
        /// Change Contractor object parameters by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="stateValue"></param>
        /// <returns></returns>
        public IEnumerable<Contractor> ChangeById(int id, string name, string phoneNumber, string email, int stateValue)
        {
            List<Contractor> selectedContractor = new List<Contractor>();
            selectedContractor.Add(_contractorList[id]);
            if (name != "")
            {
                selectedContractor[0].ChangeName(name);
            } if (phoneNumber != "")
            {
                selectedContractor[0].ChangePhoneNumber(phoneNumber);
            } if (email != "")
            {
                selectedContractor[0].ChangeEmail(email);
            }           
            selectedContractor[0].ChangeState(stateValue);
            return selectedContractor;
        }
    }
}