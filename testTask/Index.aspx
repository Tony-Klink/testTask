<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="testTask.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Test application</title>
    <style type="text/css">
        .layout {
            width: 100%;
        }

        TD {
            vertical-align: top;
            padding: 5px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            Main form</div>
        <table class="layout">
            <tr>
                <th>Customer</th>
                <th>Contractor</th>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: 700">Create customer</label>
                    <p>
                        <asp:Label ID="Label1" runat="server" Text="Enter customer name: "></asp:Label>
                        <asp:TextBox ID="CustomerNameTextBox" runat="server"></asp:TextBox>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="CustomerNameTextBox" runat="server" ErrorMessage="Name is required" />--%>
                    </p>
                    <p>
                        <asp:Label ID="Label2" runat="server" Text="Enter customer phone number: "></asp:Label>
                        <asp:TextBox ID="CustomerPhoneTextBox" runat="server"></asp:TextBox>
                       <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="CustomerPhoneTextBox"
                            ErrorMessage="Please Enter Only Numbers" ValidationExpression="^\d+$" /> --%>
                    </p>
                    <asp:Button ID="ButtonAddCustomer" runat="server" OnClick="ButtonAddCustomer_Click" Text="Add Customer" />
                    <br />
                    <br />
                    <label style="font-weight: 700">Delete customer by id</label>
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="Remove customer by number: "></asp:Label>
                        <asp:TextBox ID="CustomerIDTextBox" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonCustomerRemoveById" runat="server" Text="Remove" OnClick="ButtonCustomerRemoveById_Click" />
                    </p>
                    <label style="font-weight: 700">Display customer by id</label>
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="Display customer by number: "></asp:Label>
                        <asp:TextBox ID="CustomerIDTextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonCustomerShowById" runat="server" Text="Show" OnClick="ButtonCustomerShowById_Click" />
                    </p>
                    <label style="font-weight: 700">Edit customer by id</label>
                    <p>
                        <asp:Label ID="Label5" runat="server" Text="Customer number: "></asp:Label>
                        <asp:TextBox ID="CIDTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text="Customer Name: "></asp:Label>
                        <asp:TextBox ID="CNameTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Customer Phone number: "></asp:Label>
                        <asp:TextBox ID="CPNTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="ButtonCustomerChangeById" runat="server" Text="Change Customer" OnClick="ButtonCustomerChangeById_Click" />
                        <br />
                        <br />
                    </p>
                    <asp:Button ID="ButtonCustomerShowAll" runat="server" Text="Display Customers List" OnClick="ButtonCustomerShowAll_Click" />
                    <asp:Table ID="myTable" runat="server" Width="100%">
                        <asp:TableRow>
                            <asp:TableCell>№</asp:TableCell>
                            <asp:TableCell>Name</asp:TableCell>
                            <asp:TableCell>Phone number</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <label style="font-weight: 700">Add or remove contractors from customer</label>
                    <p>
                        <asp:Label ID="Label17" runat="server" Text="Customer number: "></asp:Label>
                        <asp:TextBox ID="CutomerIdTB2" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label18" runat="server" Text="Contractor number: "></asp:Label>
                        <asp:TextBox ID="ContractorIdTB2" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="ButtonCustomerAddContractor" runat="server" Text="Add contractor to customer" OnClick="ButtonCustomerAddContractor_Click" />
                        <br />
                        <asp:Button ID="ButtonCustomerRemoveContractor" runat="server" Text="Remove contractor from customer" OnClick="ButtonCustomerRemoveContractor_Click" />
                        <br />
                        <asp:Button ID="ButtonCustomerGetCList" runat="server" Text="Get cousmer contractors" OnClick="ButtonCustomerGetCList_Click" />
                        <br />
                    </p>
                    <asp:Table ID="ContractorListTable" runat="server" Width="100%">
                        <asp:TableRow>
                            <asp:TableCell>№</asp:TableCell>
                            <asp:TableCell>Name</asp:TableCell>
                            <asp:TableCell>Phone number</asp:TableCell>
                            <asp:TableCell>Email</asp:TableCell>
                            <asp:TableCell>State</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </td>


                <td>
                    <label style="font-weight: 700">Create contractor</label>
                    <p>
                        <asp:Label ID="Label8" runat="server" Text="Enter contractor name: "></asp:Label>
                        <asp:TextBox ID="ContractorAddNameTB" runat="server"></asp:TextBox>                        
                    </p>
                    <p>
                        <asp:Label ID="Label9" runat="server" Text="Enter contractor phone number: "></asp:Label>
                        <asp:TextBox ID="ContractorPhoneTB" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ContractorPhoneTB"
                            ErrorMessage="Please Enter Only Numbers" ValidationExpression="^\d+$" />
                    </p>
                    <p>
                        <asp:Label ID="Label15" runat="server" Text="Enter contractor email: "></asp:Label>
                        <asp:TextBox ID="ContractorEmailTB" runat="server"></asp:TextBox>
                    </p>
                    <asp:Button ID="ButtonAddContractor" runat="server" Text="Add Contractor" OnClick="ButtonAddContractor_Click" />
                    <br />
                    <br />
                    <label style="font-weight: 700">Delete contractor by id</label>
                    <p>
                        <asp:Label ID="Label10" runat="server" Text="Remove contractor by number: "></asp:Label>
                        <asp:TextBox ID="ContractorIDTextBox" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonContractorRemoveById" runat="server" Text="Remove" OnClick="ButtonContractorRemoveById_Click" />
                    </p>
                    <label style="font-weight: 700">Display contractor by id</label>
                    <p>
                        <asp:Label ID="Label11" runat="server" Text="Display contractor by number: "></asp:Label>
                        <asp:TextBox ID="ContractorIDTextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonContractorShowById" runat="server" Text="Show" OnClick="ButtonContractorShowById_Click" />
                    </p>
                    <label style="font-weight: 700">Edit contractor by id</label>
                    <p>
                        <asp:Label ID="Label12" runat="server" Text="Contractor number: "></asp:Label>
                        <asp:TextBox ID="ContIDTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label13" runat="server" Text="Contractor Name: "></asp:Label>
                        <asp:TextBox ID="ContNameTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label14" runat="server" Text="Contractor Phone number: "></asp:Label>
                        <asp:TextBox ID="ContPNTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label16" runat="server" Text="Contractor Email: "></asp:Label>
                        <asp:TextBox ID="ContEmailTextBox" runat="server"></asp:TextBox>
                        <br />
                        <label style="font-weight: 700">Change contractor state</label>
                        <asp:RadioButtonList ID="ContractorStateSelector" runat="server">
                            <asp:ListItem Selected="True" Value="0">Draft</asp:ListItem>
                            <asp:ListItem Value="1">Waiting for approve</asp:ListItem>
                            <asp:ListItem Value="2">Approved</asp:ListItem>
                            <asp:ListItem Value="3">Rejected</asp:ListItem>
                        </asp:RadioButtonList>
                        <br />
                        <asp:Button ID="ButtonContractorChangeById" runat="server" Text="Change Contractor" OnClick="ButtonContractorChangeById_Click" />
                        <br />
                        <br />
                    </p>
                    <asp:Button ID="ButtonContractorShowAll" runat="server" Text="Display Contractors List" OnClick="ButtonContractorShowAll_Click" />
                    <asp:Table ID="ContractorTable" runat="server" Width="100%">
                        <asp:TableRow>
                            <asp:TableCell>№</asp:TableCell>
                            <asp:TableCell>Name</asp:TableCell>
                            <asp:TableCell>Phone number</asp:TableCell>
                            <asp:TableCell>Email</asp:TableCell>
                             <asp:TableCell>State</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
