using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testTask.Models
{
    public class Contractor
    {
        #region Contractor state machine
        private enum State
        {
            Draft,
            WaitForApprove,
            Approved,
            Rejected
        }

        private State state;

        void setState(State value)
        {
            var prevState = state;
            switch (value)
            {
                case State.Draft:
                    if (prevState == State.WaitForApprove || prevState == State.Approved || prevState == State.Rejected)
                    {
                        break;
                    }
                    else
                    {
                        state = State.Draft;
                        break;
                    }                    
                case State.WaitForApprove:
                    if (prevState ==  State.Approved || prevState == State.Rejected)
                    {
                        break;
                    }
                    else
                    {
                        state = State.WaitForApprove;
                        break;
                    }                    
                case State.Approved:
                    if (prevState == State.Draft || prevState == State.Rejected)
                    {
                        break;
                    }
                    else
                    {
                        state = State.Approved;
                        break;
                    }                    
                case State.Rejected:
                    if (prevState == State.Draft || prevState == State.Approved)
                    {
                        break;
                    }
                    else
                    {
                        state = State.Rejected;
                        break;
                    }                    
            }
        }

        void stateDraft()
        {
            switch (state)
            {
                case State.Approved:
                    break;
                case State.Rejected:
                    break;
                case State.WaitForApprove:
                    break;
            }
            setState(State.Draft);
        }

        void stateWaitForApprove()
        {
            switch (state)
            {
                case State.Draft:
                    break;
                case State.Approved:
                    break;
                case State.Rejected:
                    break;
            }
            setState(State.WaitForApprove);
        }

        void stateApproved()
        {
            switch (state)
            {
                case State.Draft:
                    break;
                case State.WaitForApprove:
                    break;
                case State.Rejected:
                    break;
            }
            setState(State.Approved);
        }

        void stateRejected()
        {
            switch (state)
            {
                case State.Draft:
                    break;
                case State.WaitForApprove:
                    break;
                case State.Approved:
                    break;
            }
            setState(State.Rejected);
        }

        #endregion

        private string Name { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }

        /// <summary>
        /// Create new Contractor object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Contractor (string name, string phoneNumber, string email)
        {
            this.state = State.Draft;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// Returns current state
        /// </summary>
        /// <returns></returns>
        public string GetState()
        {
            return state.ToString();
        }

        /// <summary>
        /// Change Contractor State
        /// </summary>
        /// <param name="stateValue">0: Draft, 1: Wait for approve, 2: Approved, 3: Rejected</param>
        public void ChangeState(int stateValue)
        {
            switch (stateValue)
            {
                case 0:
                    stateDraft();
                    break;
                case 1:
                    stateWaitForApprove();
                    break;
                case 2:
                    stateApproved();
                    break;
                case 3:
                    stateRejected();
                    break;
            }
        }

        /// <summary>
        /// Get Name parameter of Contractor
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.Name;
        }

        /// <summary>
        /// Get PhoneNumber parameter of Contractor
        /// </summary>
        /// <returns></returns>
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        /// <summary>
        /// Get Email parameter of Contractor
        /// </summary>
        /// <returns></returns>
        public string GetEmail()
        {
            return this.Email;
        }

        /// <summary>
        /// Change Name parameter of Contractor
        /// </summary>
        /// <param name="name"></param>
        public void ChangeName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Change PhoneNumber parameter of Contractor
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void ChangePhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Change Email parameter of Contractor
        /// </summary>
        /// <param name="email"></param>
        public void ChangeEmail(string email)
        {
            this.Email = email;
        }
    }
}