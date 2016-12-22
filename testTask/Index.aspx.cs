using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testTask
{
    public partial class Index : System.Web.UI.Page
    {
        Models.CustomerProvider customerProvider = new Models.CustomerProvider();
        Models.ContractorProvider contractorProvider = new Models.ContractorProvider();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Show all customers
        protected void ButtonCustomerShowAll_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        //Create new customer
        protected void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            customerProvider.CreateCustomer(CustomerNameTextBox.Text, CustomerPhoneTextBox.Text);
            UpdateTable();
        }
        //Remove customer by id
        protected void ButtonCustomerRemoveById_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (Int32.TryParse(CustomerIDTextBox.Text, out x))
            {
                try
                {
                    customerProvider.RemoveById(x);
                    UpdateTable();
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.Write(err.Data.ToString());
                    UpdateTable();
                }
            }
        }
        //Refill tables with data
        private void UpdateTable()
        {
            #region fill table
            for (int i = 0; i < customerProvider.Count(); i++)
            {
                TableRow row = new TableRow();

                TableCell cell0 = new TableCell();
                cell0.Controls.Add(new LiteralControl(i.ToString()));
                row.Cells.Add(cell0);

                TableCell cell1 = new TableCell();
                cell1.Controls.Add(new LiteralControl(customerProvider.GetById(i).ElementAt(0).GetName()));
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Controls.Add(new LiteralControl(customerProvider.GetById(i).ElementAt(0).GetPhoneNumber()));
                row.Cells.Add(cell2);

                myTable.Rows.Add(row);
            }
            UpdateTableContractor();
            #endregion
        }

        //Select customer by id
        protected void ButtonCustomerShowById_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (Int32.TryParse(CustomerIDTextBox1.Text, out x))
            {
                try
                {
                    TableRow row = new TableRow();

                    TableCell cell0 = new TableCell();
                    cell0.Controls.Add(new LiteralControl(CustomerIDTextBox1.Text));
                    row.Cells.Add(cell0);

                    TableCell cell1 = new TableCell();
                    cell1.Controls.Add(new LiteralControl(customerProvider.GetById(x).ElementAt(0).GetName()));
                    row.Cells.Add(cell1);

                    TableCell cell2 = new TableCell();
                    cell2.Controls.Add(new LiteralControl(customerProvider.GetById(x).ElementAt(0).GetPhoneNumber()));
                    row.Cells.Add(cell2);

                    myTable.Rows.Add(row);
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.Write(err.Data.ToString());
                }
            }
        }
        //Change customer at selected id
        protected void ButtonCustomerChangeById_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (Int32.TryParse(CIDTextBox.Text, out x))
            {
                try
                {
                    customerProvider.ChangeById(x, CNameTextBox.Text, CPNTextBox.Text);
                    UpdateTable();
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.Write(err.Data.ToString());
                    UpdateTable();
                }
            }
        }
        //Create new contractor
        protected void ButtonAddContractor_Click(object sender, EventArgs e)
        {
            contractorProvider.CreateContractor(ContractorAddNameTB.Text, ContractorPhoneTB.Text, ContractorEmailTB.Text);
            UpdateTable();
        }
        //Refill table with data
        private void UpdateTableContractor()
        {
            #region fill contractor table
            for (int i = 0; i < contractorProvider.Count(); i++)
            {
                TableRow row = new TableRow();

                TableCell cell0 = new TableCell();
                cell0.Controls.Add(new LiteralControl(i.ToString()));
                row.Cells.Add(cell0);

                TableCell cell1 = new TableCell();
                cell1.Controls.Add(new LiteralControl(contractorProvider.GetById(i).ElementAt(0).GetName()));
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Controls.Add(new LiteralControl(contractorProvider.GetById(i).ElementAt(0).GetPhoneNumber()));
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Controls.Add(new LiteralControl(contractorProvider.GetById(i).ElementAt(0).GetEmail()));
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Controls.Add(new LiteralControl(contractorProvider.GetById(i).ElementAt(0).GetState()));
                row.Cells.Add(cell4);

                ContractorTable.Rows.Add(row);
            }
            #endregion
        }
        //Remove contractor by id
        protected void ButtonContractorRemoveById_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (Int32.TryParse(ContractorIDTextBox.Text, out x))
            {
                try
                {
                    contractorProvider.RemoveById(x);
                    UpdateTable();
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.Write(err.Data.ToString());
                    UpdateTable();
                }
            }
        }
        //Select contractor by id
        protected void ButtonContractorShowById_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (Int32.TryParse(ContractorIDTextBox1.Text, out x))
            {
                try
                {
                    TableRow row = new TableRow();

                    TableCell cell0 = new TableCell();
                    cell0.Controls.Add(new LiteralControl(ContractorIDTextBox1.Text));
                    row.Cells.Add(cell0);

                    TableCell cell1 = new TableCell();
                    cell1.Controls.Add(new LiteralControl(contractorProvider.GetById(x).ElementAt(0).GetName()));
                    row.Cells.Add(cell1);

                    TableCell cell2 = new TableCell();
                    cell2.Controls.Add(new LiteralControl(contractorProvider.GetById(x).ElementAt(0).GetPhoneNumber()));
                    row.Cells.Add(cell2);

                    TableCell cell3 = new TableCell();
                    cell3.Controls.Add(new LiteralControl(contractorProvider.GetById(x).ElementAt(0).GetEmail()));
                    row.Cells.Add(cell3);

                    ContractorTable.Rows.Add(row);
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.Write(err.Data.ToString());
                }
            }
        }
        //Change contractor at selected id
        protected void ButtonContractorChangeById_Click(object sender, EventArgs e)
        {
            int x = 0;
            int stateValue = 0;

            if (Int32.TryParse(ContIDTextBox.Text, out x))
            {
                if (Int32.TryParse(ContractorStateSelector.SelectedValue, out stateValue))
                {
                    try
                    {
                        contractorProvider.ChangeById(x, ContNameTextBox.Text, ContPNTextBox.Text, ContEmailTextBox.Text, stateValue);
                        UpdateTable();
                    }
                    catch (ArgumentOutOfRangeException err)
                    {
                        Console.Write(err.Data.ToString());
                        UpdateTable();
                    }
                }
            }
        }
        //Show all contractors
        protected void ButtonContractorShowAll_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        //Add contractor to customer by id
        protected void ButtonCustomerAddContractor_Click(object sender, EventArgs e)
        {
            int customerID = 0;
            int contractorID = 0;

            if (Int32.TryParse(CutomerIdTB2.Text, out customerID))
            {
                if (Int32.TryParse(ContractorIdTB2.Text, out contractorID))
                {
                    try
                    {
                        customerProvider.AddContractor(customerID, contractorID, contractorProvider.GetAll().ToList());
                        UpdateTableCustomerContractors(customerID);
                        UpdateTable();
                    }
                    catch (ArgumentOutOfRangeException err)
                    {
                        Console.Write(err.Data.ToString());
                        UpdateTable();
                    }
                }
            }
        }
        //Update CustomerContractors table
        private void UpdateTableCustomerContractors(int customerId)
        {
            #region fill contractor table
            for (int i = 0; i < customerProvider.CountContractors(customerId); i++)
            {
                TableRow row = new TableRow();

                TableCell cell0 = new TableCell();
                cell0.Controls.Add(new LiteralControl(i.ToString()));
                row.Cells.Add(cell0);

                TableCell cell1 = new TableCell();
                cell1.Controls.Add(new LiteralControl(customerProvider.GetContractorList(customerId).ElementAt(i).GetName()));
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Controls.Add(new LiteralControl(customerProvider.GetContractorList(customerId).ElementAt(i).GetPhoneNumber()));
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Controls.Add(new LiteralControl(customerProvider.GetContractorList(customerId).ElementAt(i).GetEmail()));
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Controls.Add(new LiteralControl(customerProvider.GetContractorList(customerId).ElementAt(i).GetState()));
                row.Cells.Add(cell4);

                ContractorListTable.Rows.Add(row);
            }
            #endregion
        }
        //Remove contractor from customer by id
        protected void ButtonCustomerRemoveContractor_Click(object sender, EventArgs e)
        {
            int customerID = 0;
            int contractorID = 0;

            if (Int32.TryParse(CutomerIdTB2.Text, out customerID))
            {
                if (Int32.TryParse(ContractorIdTB2.Text, out contractorID))
                {
                    try
                    {
                        customerProvider.RemoveContractorById(customerID, contractorID);
                        UpdateTableCustomerContractors(customerID);
                        UpdateTable();
                    }
                    catch (ArgumentOutOfRangeException err)
                    {
                        Console.Write(err.Data.ToString());
                        UpdateTable();
                    }
                }
            }
        }
        //Get contractors list of selected customer by id
        protected void ButtonCustomerGetCList_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (Int32.TryParse(CutomerIdTB2.Text, out x))
            {
                UpdateTableCustomerContractors(x);
            }
            UpdateTable();
        }
    }
}